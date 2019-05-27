using Reactive.Flowable;
using System;
using System.Collections.Generic;

namespace Reactive.Flowable.Test
{
    public class TestFlowable : FlowableEnumerationBase<int>
    {
        private readonly int countTo;

        public TestFlowable(int countTo = 10_000_000)
        {
            this.countTo = countTo;
        }

        protected override IEnumerator<int> GetEnumerator()
        {
            return en().GetEnumerator();
        }

        private IEnumerable<int> en()
        {
            int i = 0;
            while (i < this.countTo)
            {
                i++;
                yield return i;
            }
        }
    }
}
