using Reactive.Flowable.Flowable;
using Reactive.Flowable.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Reactive.Flowable
{
    public static partial class FlowableExtensions
    {
        public static IDisposable Subscribe<TSource>(this IFlowable<TSource> inflow, Action<TSource> onNext, Action<Exception> onError = null, Action onComplete = null)
        {
            return inflow.Subscribe(new LambdaSubscriber<TSource>((a,c) => { onNext(a); c(); }, onError, onComplete));
        }

        public static IFlowable<TResult> Select<TSource, TResult>(this IFlowable<TSource> inflow, Func<TSource, TResult> map)
        {
            return new FlowableWithUpstream<TSource, TResult>(inflow, (x, s) => s.OnNext(map(x)));
        }

        public static IFlowable<TSource> Where<TSource>(this IFlowable<TSource> inflow, Func<TSource, bool> filter)
        {
            return new FlowableWithUpstream<TSource, TSource>(inflow, 
                (x, s) => {
                    if (filter(x))
                    {
                        s.OnNext(x);
                    }
                });
        }

        public static IFlowable<TSource> Delay<TSource>(this IFlowable<TSource> inflow, TimeSpan delay)
        {
            return new FlowableWithUpstream<TSource, TSource>(inflow,
                (x, s) => {
                    Thread.Sleep(delay);
                    s.OnNext(x);
                });
        }

        public static IFlowable<TSource> Delay<TSource>(this IFlowable<TSource> inflow, int miliseconds)
        {
            return new FlowableWithUpstream<TSource, TSource>(inflow, 
                (x, s) => {
                    Thread.Sleep(miliseconds);
                    s.OnNext(x);
                });
        }

        ////public static IFlowable<T> Merge<T>(this IFlowable<T> first, IFlowable<T> second)
        ////{
        ////    return new MergeFlowable<T>(first, second);
        ////}

        public static IFlowable<T> Merge<T>(this IFlowable<T> first, IEnumerable<IFlowable<T>> rest)
        {
            var lst = new List<IFlowable<T>>() { first };
            lst.AddRange(rest);
            return new FlowableMerge<T>(lst);
        }

        public static IFlowable<T> Merge<T>(this IFlowable<T> first, params IFlowable<T>[] list)
        {
            var lst = new List<IFlowable<T>>() { first };
            lst.AddRange(list);
            return new FlowableMerge<T>(lst);
        }

        public static IFlowable<T> AsFlowable<T>(this IEnumerable<T> enumerable)
        {
            return new FlowableFromEnumerable<T>(enumerable);
        }

        internal static IEnumerable<Tx> AsRoundRobbin<Tx>(this IEnumerable<Tx> enumerable)
        {
            var enumerator = enumerable.ToArray().GetEnumerator() as IEnumerator<Tx>;
            while (true)
            {
                if (enumerator.MoveNext())
                {
                    yield return enumerator.Current;
                }
                else
                {
                    enumerator.Reset();
                }
            }
        }
    }
}