using System;

namespace Reactive.Flowable.Subscriber
{
    public class LambdaSubscriber<T> : Subscriber<T>
    {
        private readonly Action<T, Action> onNext;
        private readonly Action<Exception> onError;
        private readonly Action onComplete;
        private readonly Action<ISubscription, Action> onSubscribe;
        private readonly Action<int, ISubscription> onRequest;

        public LambdaSubscriber(Action<T, Action> onNext, Action<Exception> onError = null, Action onComplete = null, Action<ISubscription, Action> onSubscribe = null, Action<int, ISubscription> onRequest = null)
        {
            this.onNext = onNext;
            this.onError = onError?? (x => { });
            this.onComplete = onComplete ?? (() => { });
            this.onSubscribe = onSubscribe ?? ((x, continuation) => { continuation(); });
            this.onRequest = onRequest?? ((int n, ISubscription s) => s.Request(n));
        }

        protected override void OnErrorCore(Exception error)
        {
            onError(error);
        }

        protected override void OnNextCore(T value, Action continuation)
        {
            onNext(value, continuation);
        }

        protected override void OnSubscribeCore(ISubscription subscriber, Action continuation)
        {
            onSubscribe(subscriber, continuation);
        }

        protected override void OnCompleteCore()
        {
            onComplete();
        }

        protected override void OnRequestCore(int n, ISubscription subscription)
        {
            this.onRequest(n, subscription);
        }
    }
}
