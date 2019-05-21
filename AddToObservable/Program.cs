using Reactive.Flowable.Test;
using Reactive.Flowable;
using System;
using Reactive.Flowable.Flowable;

namespace AddToObservable
{
    class Program
    {
        static void Main(string[] args)
        {
            var testf = new TestFlowable();
            var testg = new TestFlowable();

            testf.Merge(testg).Subscribe(x => Console.WriteLine(x));

            //var test = new MergeFlowable<int>(testf, testg);
            //test.Subscribe(x => Console.WriteLine(x));
            //testf
            //    .Where(x => x % 10 == 0)
            //    //.Delay(1000)
            //    .Select(x => $"Foo - {x}")
            //    .Subscribe(x => Console.WriteLine(x));


            while (true)
            {
                if(Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    break;
                }
            }


        }
    }
}