using System.Collections.Generic;

namespace Reactive.Flowable
{
    internal class FlowableFromEnumerable<T> : FlowableEnumerationBase<T>
    {
        private IEnumerable<T> items;

        public FlowableFromEnumerable(IEnumerable<T> items)
        {
            this.items = items;
        }

        protected override IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}