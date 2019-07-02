using Reactive.Flowable.Test;
using Reactive.Flowable;
using System;
using Reactive.Flowable.Flowable;
using System.Collections.Concurrent;
using System.Threading;

namespace AddToObservable
{
    class Program
    {
        public static class NonBlockingConsole
        {
            private static BlockingCollection<string> m_Queue = new BlockingCollection<string>();

            static NonBlockingConsole()
            {
                var thread = new Thread(
                  () =>
                  {
                      while (true) Console.WriteLine(m_Queue.Take());
                  });
                thread.IsBackground = true;
                thread.Start();
            }

            public static void WriteLine(string value)
            {
                m_Queue.Add(value);
            }
        }

        static void Main(string[] args)
        {
            var testf = new TestFlowable(10);
            var testg = new TestFlowable(10);
            var testh = new TestFlowable(10);

            testf
                .Merge(testg, testh)
                .Subscribe(x => NonBlockingConsole.WriteLine(x.ToString()));

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