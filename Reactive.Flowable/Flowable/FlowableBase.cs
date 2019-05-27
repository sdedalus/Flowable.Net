using Reactive.Flowable.Subscriber;
using System;

namespace Reactive.Flowable
{

    public abstract partial class FlowableSourceBase<T> : IFlowable<T>
    {
        public virtual IDisposable Subscribe(ISubscriber<T> subscriber)
        {
            var s = GetSubscription(subscriber);
            subscriber.OnSubscribe(s);
            return s;
        }

        protected abstract ISubscription GetSubscription(ISubscriber<T> subscriber);
    }
}