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
        {
            Upstream.Add(flow1.Select(v => Maybe<TReturn>.AsSome(v)));
            Upstream.Add(flow2.Select(v => Maybe<TReturn>.AsSome(v)));

            this.filter = filter ?? (
                (Maybe<TReturn> a, ISubscriber<TReturn> b) => {
                    if (a is Maybe<TReturn>.Some some)
                    {
                        b.OnNext(some.Value);
                    }
                });
        }

        public FlowableMerge(IEnumerable<IFlowable<TReturn>> flow, Action<Maybe<TReturn>, ISubscriber<TReturn>> filter = null)
        {
            Upstream.AddRange(flow.Select(f => f.Select(v => Maybe<TReturn>.AsSome(v))));

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

            IFlowable<TReturn> fl = new FlowableWithUpstream<ISubscriber<Maybe<TReturn>>, TReturn>(flowN, (x, s) =>
            {
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
                });

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
        public static Maybe<T> AsSome(T value)
        {
            return new Some(value);
        }

        public class Some : Maybe<T>
        {
            public Some(T value)
            {
                Value = value;
            }

            public T Value { get; }

            public override bool IsSome => true;
        }

        public class None : Maybe<T>
        {
            public override bool IsSome => false;
        }

        public abstract bool IsSome
        {
            get;
        }
    }
}
