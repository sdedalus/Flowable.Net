using Reactive.Flowable.Subscriber;
using System;
using System.Threading;

namespace Reactive.Flowable.Flowable
{
    public class ProxySubscriber<T> : ISubscriber<T>
    {
        private readonly ISubscriber<T> subscriber;
        private SubscriberState state = SubscriberState.Created;
        private int demand = 0;

        public ProxySubscriber(ISubscriber<T> subscriber) => 
            this.subscriber = subscriber 
                ?? throw new ArgumentNullException(nameof(subscriber));

        public SubscriberState State { get => state; }

        public void Cancel()
        {
            this.state = SubscriberState.Canceled;
            subscriber.Cancel();
        }

        public void Dispose()
        {
            this.state = SubscriberState.Disposed;
            subscriber.Dispose();
        }

        public void OnComplete()
        {
            this.state = SubscriberState.Completed;
            subscriber.OnComplete();
        }

        public void OnError(Exception error)
        {
            subscriber.OnError(error);
        }

        public void OnNext(T value)
        {
            Interlocked.Decrement(ref demand);
            subscriber.OnNext(value);
        }

        public void OnSubscribe(ISubscription subscription)
        {
            this.state = SubscriberState.Subscribed;
            subscriber.OnSubscribe(subscription);
        }

        public void Request(int n)
        {
            Interlocked.Add(ref demand, n);
            subscriber.Request(n);
        }
    }
}
