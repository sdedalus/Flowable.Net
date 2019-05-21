using Reactive.Flowable.Subscriber;
using System.Collections.Generic;

namespace Reactive.Flowable
{
    public abstract class FlowableEnumerationBase<T> : FlowableBase<T>
    {
        protected override ISubscription GetSubscription(ISubscriber<T> subscriber)
        {
            return new EnumeratorSubscription<T>(GetEnumerator(), subscriber, 1);
        }

        protected abstract IEnumerator<T> GetEnumerator();
    }
}