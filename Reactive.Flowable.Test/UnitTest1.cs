using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Reactive.Flowable.Test
{
    [TestClass]
    public class SubscribeTests
    {
        [TestMethod]
        public async Task testSingleSource()
        {
            var num = 1_000_000;
            Assert
                .AreEqual(
                (num + 1) * (num / 2),
                await Task.Factory.StartNew(val =>
                {
                    int count = (int)val;
                    bool continueFlag = false;
                    var testf = new TestFlowable(count);
                    int sum = 0;
                    var tmp = testf
                        .Subscribe(
                        onNext: x => Interlocked.Add(ref sum, x),
                        onComplete: () =>
                        {
                            continueFlag = true;
                        });
                    // this is kind of a hack...
                    while (!continueFlag) {
                        Thread.Sleep(10);
                    };
                    return sum;
                }, num));
        }

        [TestMethod]
        public async Task testTwoSources()
        {
            var num = 10;
            Assert
                .AreEqual(
                (num + 1) * (num / 2) * 2,  
                await Task.Factory.StartNew(val =>
                {
                    int count = (int)val;
                    bool continueFlag = false;
                    var testf = new TestFlowable(count);
                    var testg = new TestFlowable(count);
                    int sum = 0;
                    var tmp = testf
                        .Merge(testg)
                        .Subscribe(
                        onNext: x => sum += x,
                        onComplete: () =>
                        {
                            continueFlag = true;
                        });

                    while (!continueFlag) { };
                    return sum;
                }, num));
        }

        [TestMethod]
        public async Task testThreeSources()
        {
            var num = 30;
            Assert
                .AreEqual(
                (num + 1) * (num / 2) * 3,
                await Task.Factory.StartNew(val =>
                {
                    int count = (int)val;
                    bool continueFlag = false;
                    var testf = new TestFlowable(count);
                    var testg = new TestFlowable(count);
                    var testh = new TestFlowable(count);
                    int sum = 0;
                    var tmp = testf
                        .Merge(testg, testh)
                        .Subscribe(
                        onNext: x => sum += x,
                        onComplete: () =>
                        {
                            continueFlag = true;
                        });

                    while (!continueFlag) { };
                    return sum;
                }, num));
        }
    }
}
