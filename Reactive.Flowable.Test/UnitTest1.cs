using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Reactive.Flowable.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task testSingleSource()
        {
            await Task.Factory.StartNew(() =>
            {
                bool continueFlag = false;
                var count = 1000;
                var testf = new TestFlowable(count);
                int sum = 0;
                testf.Subscribe(
                    onNext: x => sum += x,
                    onComplete: () => {
                        Assert.AreEqual((count + 1) * (count / 2), sum);
                        continueFlag = true;
                    });

                while (!continueFlag) { };
            });
        }

        [TestMethod]
        public async Task testTwoSources()
        {
            await Task.Factory.StartNew(() =>
            {
                bool continueFlag = false;
                var count = 1000;
                var testf = new TestFlowable(count);
                var testg = new TestFlowable(count);
                int sum = 0;
                _ = testf
                    .Merge(testg)
                    .Subscribe(
                    onNext: x => sum += x,
                    onComplete: () =>
                    {
                        Assert.AreEqual((count + 1) * (count / 2) * 2, sum);
                        continueFlag = true;
                    });

                while (!continueFlag) { };
            });
        }
    }
}
