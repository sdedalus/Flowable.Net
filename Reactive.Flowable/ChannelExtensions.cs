using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Reactive.Flowable
{
    internal static class ChannelExtensions
    {
        public static IEnumerable<Task> Subscribe<T>(this Channel<T> chanel, Action<T> action, CancellationToken cancellationToken, int concurrency = 1)
        {
            var reader = chanel.Reader;

            async Task Read(ChannelReader<T> theReader)
            {
                //while when channel is not complete 
                while (await theReader.WaitToReadAsync())
                {
                    while (theReader.TryRead(out var theMessage))
                    {
                        action(theMessage);
                    }
                }
            }

            var tasks = new List<Task>();
            for (int i = 0; i < concurrency; i++)
            {
                tasks.Add(Task.Factory.StartNew(() => Read(reader), cancellationToken));
            }

            return tasks;
        }
    }
}
