using Reactive.Flowable.Subscriber;
using System;

namespace Reactive.Flowable.Test
{
    public class ConsoleSubscriber : Subscriber<string>
    {
        private readonly string label;
        private ISubscription subscription;
        public ConsoleSubscriber(string label)
        {
            this.label = label;
        }

        protected override void OnCompleteCore()
        {
            Console.WriteLine($"{label}> OnCompleted");
        }

        protected override void OnErrorCore(Exception error)
        {
            Console.WriteLine($"{label}> OnError");
            Console.WriteLine(error);
        }

        protected override void OnNextCore(string value, Action continuation)
        {
            Console.WriteLine($"{label}> OnNext");
            Console.WriteLine(value);
            continuation();
        }

        protected override void OnSubscribeCore(ISubscription subscription, Action continuation)
        {
            Console.WriteLine($"{label}> OnSubscribe");
            Console.WriteLine(subscription);
            continuation();
        }
    }


    public class NoOpSubscriber<T> : Subscriber<T>
    {
        public NoOpSubscriber()
        {
        }

        protected override void OnCompleteCore()
        {
        }

        protected override void OnErrorCore(Exception error)
        {
        }

        protected override void OnNextCore(T value, Action continuation)
        {
            continuation();
        }

        protected override void OnSubscribeCore(ISubscription subscription, Action continuation)
        {
            continuation();
        }
    }
}