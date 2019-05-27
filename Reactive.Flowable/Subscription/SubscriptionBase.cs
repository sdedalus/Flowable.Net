using Reactive.Flowable.Subscriber;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Reactive.Flowable
{
    public abstract class SubscriptionBase<T> : ISubscription
    {
        private readonly CancellationTokenSource cancelSource;
        private readonly ISubscriber<T> subscriber;
        private IEnumerable<Task> readerTasks;
        private ChannelWriter<T> writer;
        private Task writerTask;
        private int demand = 0;

        protected SubscriptionBase(ISubscriber<T> subscriber, BoundedChannelOptions options)
        {
            cancelSource = new CancellationTokenSource();
            demand = options.Capacity;

            Channel<T> channel = Channel.CreateBounded<T>(options);
            writer = channel.Writer;

            readerTasks = channel.Subscribe(x => subscriber.OnNext(x), cancelSource.Token, options.Capacity);

            writerTask = Task.Factory.StartNew(ProcessRequestAsync);

            Request(options.Capacity);
            this.subscriber = subscriber;
        }

        public void Cancel()
        {
            cancelSource.Cancel();
            writer.Complete();
            subscriber.OnComplete();
        }

        public void Request(int n)
        {
            Interlocked.Add(ref demand, n);
        }

        protected virtual async Task ProcessRequestAsync()
        {
            while (true)
            {
                int n = Interlocked.Exchange(ref demand, 0);
                for (int i = 0; i < n; i++)
                {
                    if (AdvanceRead())
                    {
                        await writer.WriteAsync(GetCurrent());
                    }
                    else
                    {
                        Cancel();
                        return;
                    }
                }
            }
        }

        protected abstract bool AdvanceRead();

        protected abstract T GetCurrent();

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    cancelSource.Cancel();

                    Task.WhenAll(readerTasks).Wait();
                }

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
