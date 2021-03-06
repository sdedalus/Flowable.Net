﻿using Reactive.Flowable.Subscriber;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Reactive.Flowable
{
    public abstract class SubscriptionBaseAsync<T> : ISubscription
    {
        private readonly CancellationTokenSource cancelSource;
        private IEnumerable<Task> readerTasks;
        private ChannelWriter<T> writer;
        private Task writerTask;
        private int maxParallel = 0;

        protected SubscriptionBaseAsync(ISubscriber<T> subscriber, int maxParallel = 10)
           : this(subscriber, new BoundedChannelOptions(maxParallel) { FullMode = BoundedChannelFullMode.Wait })
        {
            this.maxParallel = maxParallel;
        }

        protected SubscriptionBaseAsync(ISubscriber<T> subscriber, BoundedChannelOptions options)
        {
            cancelSource = new CancellationTokenSource();
            maxParallel = options.Capacity;

            Channel<T> channel = Channel.CreateBounded<T>(options);
            writer = channel.Writer;

            readerTasks = channel.Subscribe(x => subscriber.OnNext(x), cancelSource.Token, options.Capacity);

            writerTask = Task.Factory.StartNew(ProcessRequestAsync);

            Request(options.Capacity);
        }

        public void Cancel()
        {
            cancelSource.Cancel();
            writer.Complete();
        }

        public void Request(int n)
        {
            Interlocked.Add(ref maxParallel, n);
        }

        protected virtual async Task ProcessRequestAsync()
        {
            while (true)
            {
                int n = Interlocked.Exchange(ref maxParallel, 0);
                for (int i = 0; i < n; i++)
                {
                    if (await AdvanceRead())
                    {
                        await writer.WriteAsync(await GetCurrent());
                    }
                    else
                    {
                        Cancel();
                        return;
                    }
                }
            }
        }

        protected abstract Task<bool> AdvanceRead();

        protected abstract Task<T> GetCurrent();

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    cancelSource.Cancel();
                    ////itemEnumerator.Dispose();
                    ////itemEnumerator = null;

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
