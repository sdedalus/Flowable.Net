using Reactive.Flowable;
using System;
using System.Collections.Generic;

namespace Reactive.Flowable.Test
{
    public class TestFlowable : FlowableEnumerationBase<int>
    {
        protected override IEnumerator<int> GetEnumerator()
        {
            return en().GetEnumerator();
        }

        private IEnumerable<int> en()
        {
            int i = 0;
            while (i < 10_000_000)
            {
                i++;
                ////Console.WriteLine("yield");
                yield return i;
            }
        }
    }
}
