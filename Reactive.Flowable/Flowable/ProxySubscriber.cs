using Reactive.Flowable.Subscriber;
using System;

namespace Reactive.Flowable.Flowable
{
    public class ProxySubscriber<T> : ISubscriber<T>
    {
        private readonly ISubscriber<T> subscriber;
        private SubscriberState state = SubscriberState.Created;

        public ProxySubscriber(ISubscriber<T> subscriber) => 
            this.subscriber = subscriber 
                ?? throw new ArgumentNullException(nameof(subscriber));

        public SubscriberState State { get => state; }

        public void Cancel()
        {
            subscriber.Cancel();
            this.state = SubscriberState.Canceled;
        }

        public void Dispose()
        {
            subscriber.Dispose();
            this.state = SubscriberState.Disposed;
        }

        public void OnComplete()
        {
            subscriber.OnComplete();
            this.state = SubscriberState.Completed;
        }

        public void OnError(Exception error)
        {
            subscriber.OnError(error);
        }

        public void OnNext(T value)
        {
            subscriber.OnNext(value);
        }

        public void OnSubscribe(ISubscription subscription)
        {
            subscriber.OnSubscribe(subscription);
            this.state = SubscriberState.Subscribed;
        }

        public void Request(int n)
        {
            subscriber.Request(n);
        }
    }
}
