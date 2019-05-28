using Reactive.Flowable;
using Reactive.Flowable.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reactive.Flowable.Flowable
{
    public class FlowableMerge<TReturn> : IFlowable<TReturn>
    {
        private List<IFlowable<Maybe<TReturn>>> Upstream = new List<IFlowable<Maybe<TReturn>>>();
        Action<Maybe<TReturn>, ISubscriber<TReturn>> filter;

        public FlowableMerge(IFlowable<TReturn> flow1, IFlowable<TReturn> flow2, Action<Maybe<TReturn>, ISubscriber<TReturn>> filter = null)
            : this(new List<IFlowable<TReturn>>() { flow1, flow2 })
        {
        }

        public FlowableMerge(IEnumerable<IFlowable<TReturn>> flow, Action<Maybe<TReturn>, ISubscriber<TReturn>> filter = null)
        {
            Upstream.AddRange(flow.Select(f => f.Select(v => Maybe<TReturn>.AsSome(v, f.GetHashCode()))));

            this.filter = filter ?? (
                (Maybe<TReturn> a, ISubscriber<TReturn> b) => {
                    if (a is Maybe<TReturn>.Some some)
                    {
                        b.OnNext(some.Value);
                    }
                });
        }

        public IDisposable Subscribe(ISubscriber<TReturn> subscriber)
        {
            var flowN = Upstream
                .Select(x => SubscriberToFlow(subscriber, x))
                .AsRoundRobbin()
                .AsFlowable();

            IFlowable<TReturn> fl = new FlowableWithUpstream<ISubscriber<Maybe<TReturn>>, TReturn>(
                flowN, 
                (x, s) => {
                    if (x is Maybe<TReturn>.Some some)
                    {
                        s.OnNext(some.Value);
                    }
                },
                onRequestFilter: (r, s) => {
                    s.Request(r);
                });

            fl.Subscribe(subscriber);
            return subscriber;
        }

        private ISubscriber<Maybe<TReturn>> SubscriberToFlow(ISubscriber<TReturn> subscriber, IFlowable<Maybe<TReturn>> flow)
        {
            var composed = FilterComposer(subscriber, filter);
            var sourceSubscriber = new LambdaSubscriber<Maybe<TReturn>>(
                onNext: (x,c) => {
                    composed(x);
                    c();
                },
                onRequest: (r, s) => {
                    s.Request(r);
                },
                onComplete: () => { });

            flow.Subscribe(sourceSubscriber);
            return sourceSubscriber;
        }

        protected Action<Maybe<TReturn>> FilterComposer(ISubscriber<TReturn> subscriber, Action<Maybe<TReturn>, ISubscriber<TReturn>> filter)
        {
            return x => filter(x, subscriber);
        }
    }

    public abstract class Maybe<T>
    {
        private readonly int tag;

        public Maybe(int tag)
        {
            this.tag = tag;
        }

        public abstract bool IsSome
        {
            get;
        }

        public int Tag => tag;

        public static Maybe<T> AsSome(T value, int tag)
        {
            return new Some(value, tag);
        }

        public static Maybe<T> AsNone(T value, int tag)
        {
            return new None(tag);
        }

        public class Some : Maybe<T>
        {
            public Some(T value, int tag) : base(tag)
            {
                Value = value;
            }

            public T Value { get; }

            public override bool IsSome => true;
        }

        public class None : Maybe<T>
        {
            public None(int tag) : base(tag)
            {

            }

            public override bool IsSome => false;
        }
    }
}
