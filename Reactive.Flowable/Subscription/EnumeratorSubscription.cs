using Reactive.Flowable.Subscriber;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Reactive.Flowable
{
    public class EnumeratorSubscription<T> : SubscriptionBase<T>
    {
        private IEnumerator<T> itemEnumerator;

        public EnumeratorSubscription(IEnumerator<T> itemEnumerator, ISubscriber<T> subscriber, int maxParallel = 10)
           : base(subscriber, new BoundedChannelOptions(maxParallel) { FullMode = BoundedChannelFullMode.Wait })
        {
            this.itemEnumerator = itemEnumerator;
        }

        public EnumeratorSubscription(IEnumerator<T> itemEnumerator, ISubscriber<T> subscriber, BoundedChannelOptions options)
            : base(subscriber, options)
        {
            this.itemEnumerator = itemEnumerator;
        }

        protected override bool AdvanceRead()
        {
            return itemEnumerator.MoveNext();
        }

        protected override T GetCurrent()
        {
            return itemEnumerator.Current;
        }
    }
}
