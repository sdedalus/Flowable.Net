using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reactive.Flowable.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var count = 10_000_000;
            var testf = new TestFlowable(count);
            int sum = 0;
            testf.Subscribe(x => sum += x);

            Assert.AreEqual((count + 1) * (count / 2), sum);
        }
    }
}
