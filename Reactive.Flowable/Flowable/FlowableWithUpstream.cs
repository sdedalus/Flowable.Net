using Reactive.Flowable.Subscriber;
using System;

namespace Reactive.Flowable
{
    public class FlowableWithUpstream<T, R> : IFlowable<R>
    {
        private readonly IFlowable<T> upstream;
        Action<T, ISubscriber<R>> onNextFilter;
        private readonly Action<int, ISubscription> onRequestFilter;

        public FlowableWithUpstream(IFlowable<T> upstream, Action<T, ISubscriber<R>> onNextFilter, Action<int, ISubscription> onRequestFilter = null)
        {
            this.upstream = upstream;
            this.onNextFilter = onNextFilter;
            this.onRequestFilter = onRequestFilter ?? ((n, s) => {
                s.Request(n);
            });
        }

        public IDisposable Subscribe(ISubscriber<R> subscriber)
        {
            var upSubscriber = new LambdaSubscriber<T>(
                onNext: FilterComposer(subscriber),
                onError: subscriber.OnError,
                onComplete: subscriber.OnComplete,
                onSubscribe: (s, c) =>
                {
                    subscriber.OnSubscribe(s);
                    c();                    
                },
                onRequest: this.onRequestFilter);

            return upstream.Subscribe(upSubscriber);
        }

        protected Action<T, Action> FilterComposer(ISubscriber<R> subscriber)
        {
            return (x, c) =>
            {
                onNextFilter(x, subscriber);
                c();
            };
        }

        public IDisposable Subscribe(IObserver<R> observer)
        {
            throw new NotImplementedException();
        }
    }
}