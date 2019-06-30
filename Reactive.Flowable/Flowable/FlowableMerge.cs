using Reactive.Flowable;
using Reactive.Flowable.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Reactive.Flowable.Flowable
{
    public class FlowableMerge<TReturn> : FlowableMergeBase<TReturn, Maybe<TReturn>>
    {
        public FlowableMerge(IEnumerable<IFlowable<TReturn>> flow, Action<Maybe<TReturn>, ISubscriber<TReturn>> filter = null) 
            : base(flow)
        {
        }

        public FlowableMerge(IFlowable<TReturn> flow1, IFlowable<TReturn> flow2, Action<Maybe<TReturn>, ISubscriber<TReturn>> filter = null) 
            : base(flow1, flow2)
        {
        }

        protected override void ContinueWhen(ISubscriber<Maybe<TReturn>> x, ISubscriber<TReturn> s)
        {
            if (x is Maybe<TReturn>.Some some)
            {
                s.OnNext(some.Value);
            }
        }

        protected override void MergeFilter(Maybe<TReturn> inValue, ISubscriber<TReturn> outSubscriber)
        {
            if (inValue is Maybe<TReturn>.Some some)
            {
                outSubscriber.OnNext(some.Value);
            }
        }

        protected override Maybe<TReturn> Tointernal(IFlowable<TReturn> f, TReturn v)
        {
            return Maybe<TReturn>.AsSome(v, f.GetHashCode());
        }
    }

    public abstract class FlowableMergeBase<TReturn, Tinternal> : IFlowable<TReturn>
    {
        private List<IFlowable<Tinternal>> Upstream = new List<IFlowable<Tinternal>>();

        public FlowableMergeBase(IFlowable<TReturn> flow1, IFlowable<TReturn> flow2)
            : this(new List<IFlowable<TReturn>>() { flow1, flow2 })
        {
        }

        public FlowableMergeBase(IEnumerable<IFlowable<TReturn>> flow)
        {
            Upstream.AddRange(flow.Select(f => f.Select(v => Tointernal(f, v))));
        }

        public IDisposable Subscribe(ISubscriber<TReturn> subscriber)
        {
            int cancelations = 0;
            int cancelCount = Upstream.Count();
            Action complete = () =>
            {
                if (Interlocked.Increment(ref cancelations) == cancelCount)
                {
                    subscriber.OnComplete();
                }
            };

            var flowN = Upstream
                .Select(x => SubscriberToFlow(subscriber, x, complete))
                .AsRoundRobbin()
                .Where( x=> x.State == SubscriberState.Subscribed)
                .AsFlowable();

            IFlowable<TReturn> fl = new FlowableWithUpstream<ISubscriber<Tinternal>, TReturn>(
                flowN, 
                (x, s) =>
                {
                    ContinueWhen(x, s);
                },
                onRequestFilter: (r, s) => {
                    s.Request(r);
                });

            fl.Subscribe(subscriber);
            return subscriber;
        }

        protected abstract void ContinueWhen(ISubscriber<Tinternal> x, ISubscriber<TReturn> s);

        protected abstract Tinternal Tointernal(IFlowable<TReturn> f, TReturn v);

        protected abstract void MergeFilter(Tinternal inValue, ISubscriber<TReturn> outSubscriber);

        protected Action<Tinternal> FilterComposer(ISubscriber<TReturn> subscriber, Action<Tinternal, ISubscriber<TReturn>> filter)
        {
            return x => filter(x, subscriber);
        }

        private ProxySubscriber<Tinternal> SubscriberToFlow(ISubscriber<TReturn> subscriber, IFlowable<Tinternal> flow, Action onComplete)
        {
            var composed = FilterComposer(subscriber, (a,b) => MergeFilter(a, b));
            var sourceSubscriber = new ProxySubscriber<Tinternal>( new LambdaSubscriber<Tinternal>(
                onNext: (x,c) => {
                    composed(x);
                    c();
                },
                onRequest: (r, s) => {
                    s.Request(r);
                },
                onComplete: onComplete));

            flow.Subscribe(sourceSubscriber);
            return sourceSubscriber;
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
