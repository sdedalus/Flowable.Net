using System.Collections.Generic;

namespace Reactive.Flowable
{
    public static partial class FlowableExtensions
    {
        //public static T Flowable<T> amb(Iterable<? extends Publisher<? extends T>> sources)
        //{
        //          ObjectHelper.requireNonNull(sources, "sources is null");
        //          return RxJavaPlugins.onAssembly(new FlowableAmb<T>(null, sources));
        //}


        //public static T Flowable<T> ambArray(Publisher<? extends T>...sources)
        //{
        //          ObjectHelper.requireNonNull(sources, "sources is null");
        //          int len = sources.length;
        //          if (len == 0)
        //          {
        //              return empty();
        //          }
        //          else
        //          if (len == 1)
        //          {
        //              return fromPublisher(sources[0]);
        //          }
        //          return RxJavaPlugins.onAssembly(new FlowableAmb<T>(sources, null));
        //      }


        //      public static <T, R> Flowable<R> combineLatest(Publisher<? extends T>[] sources, Function<? super Object[], ? extends R> combiner)
        //      {
        //          return combineLatest(sources, combiner, bufferSize());
        //      }

        //      public static <T, R> Flowable<R> combineLatest(Function<? super Object[], ? extends R> combiner, Publisher<? extends T>...sources)
        //      {
        //          return combineLatest(sources, combiner, bufferSize());
        //      }

        //      public static <T, R> Flowable<R> combineLatest(Publisher<? extends T>[] sources, Function<? super Object[], ? extends R> combiner, int bufferSize)
        //      {
        //          ObjectHelper.requireNonNull(sources, "sources is null");
        //          if (sources.length == 0)
        //          {
        //              return empty();
        //          }
        //          ObjectHelper.requireNonNull(combiner, "combiner is null");
        //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
        //          return RxJavaPlugins.onAssembly(new FlowableCombineLatest<T, R>(sources, combiner, bufferSize, false));
        //      }

        //      public static <T, R> Flowable<R> combineLatest(Iterable<? extends Publisher<? extends T>> sources,
        //              Function<? super Object[], ? extends R> combiner)
        //      {
        //          return combineLatest(sources, combiner, bufferSize());
        //      }

        //      public static <T, R> Flowable<R> combineLatest(Iterable<? extends Publisher<? extends T>> sources,
        //              Function<? super Object[], ? extends R> combiner, int bufferSize)
        //      {
        //          ObjectHelper.requireNonNull(sources, "sources is null");
        //          ObjectHelper.requireNonNull(combiner, "combiner is null");
        //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
        //          return RxJavaPlugins.onAssembly(new FlowableCombineLatest<T, R>(sources, combiner, bufferSize, false));
        //      }

        //      public static <T, R> Flowable<R> combineLatestDelayError(Publisher<? extends T>[] sources,
        //              Function<? super Object[], ? extends R> combiner)
        //      {
        //          return combineLatestDelayError(sources, combiner, bufferSize());
        //      }


        //      public static <T, R> Flowable<R> combineLatestDelayError(Function<? super Object[], ? extends R> combiner,
        //              Publisher<? extends T>...sources)
        //      {
        //          return combineLatestDelayError(sources, combiner, bufferSize());
        //      }


        //      public static <T, R> Flowable<R> combineLatestDelayError(Function<? super Object[], ? extends R> combiner,
        //              int bufferSize, Publisher<? extends T>...sources)
        //      {
        //          return combineLatestDelayError(sources, combiner, bufferSize);
        //      }


        //      public static <T, R> Flowable<R> combineLatestDelayError(Publisher<? extends T>[] sources,
        //              Function<? super Object[], ? extends R> combiner, int bufferSize)
        //      {
        //          ObjectHelper.requireNonNull(sources, "sources is null");
        //          ObjectHelper.requireNonNull(combiner, "combiner is null");
        //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
        //          if (sources.length == 0)
        //          {
        //              return empty();
        //          }
        //          return RxJavaPlugins.onAssembly(new FlowableCombineLatest<T, R>(sources, combiner, bufferSize, true));
        //      }


        //      public static <T, R> Flowable<R> combineLatestDelayError(Iterable<? extends Publisher<? extends T>> sources,
        //              Function<? super Object[], ? extends R> combiner)
        //      {
        //          return combineLatestDelayError(sources, combiner, bufferSize());
        //      }


        //      public static <T, R> Flowable<R> combineLatestDelayError(Iterable<? extends Publisher<? extends T>> sources,
        //              Function<? super Object[], ? extends R> combiner, int bufferSize)
        //      {
        //          ObjectHelper.requireNonNull(sources, "sources is null");
        //          ObjectHelper.requireNonNull(combiner, "combiner is null");
        //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
        //          return RxJavaPlugins.onAssembly(new FlowableCombineLatest<T, R>(sources, combiner, bufferSize, true));
        //      }

        //      public static <T1, T2, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              BiFunction<? super T1, ? super T2, ? extends R> combiner)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          Function<Object[], R> f = Functions.toFunction(combiner);
        //          return combineLatest(f, source1, source2);
        //      }


        //      public static <T1, T2, T3, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              Publisher<? extends T3> source3,
        //              Function3<? super T1, ? super T2, ? super T3, ? extends R> combiner)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          return combineLatest(Functions.toFunction(combiner), source1, source2, source3);
        //      }

        //      public static <T1, T2, T3, T4, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              Publisher<? extends T3> source3, Publisher<? extends T4> source4,
        //              Function4<? super T1, ? super T2, ? super T3, ? super T4, ? extends R> combiner)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          return combineLatest(Functions.toFunction(combiner), source1, source2, source3, source4);
        //      }

        //      public static <T1, T2, T3, T4, T5, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              Publisher<? extends T3> source3, Publisher<? extends T4> source4,
        //              Publisher<? extends T5> source5,
        //              Function5<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? extends R> combiner)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          ObjectHelper.requireNonNull(source5, "source5 is null");
        //          return combineLatest(Functions.toFunction(combiner), source1, source2, source3, source4, source5);
        //      }

        //      public static <T1, T2, T3, T4, T5, T6, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              Publisher<? extends T3> source3, Publisher<? extends T4> source4,
        //              Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Function6<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? extends R> combiner)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          ObjectHelper.requireNonNull(source5, "source5 is null");
        //          ObjectHelper.requireNonNull(source6, "source6 is null");
        //          return combineLatest(Functions.toFunction(combiner), source1, source2, source3, source4, source5, source6);
        //      }

        //      public static <T1, T2, T3, T4, T5, T6, T7, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              Publisher<? extends T3> source3, Publisher<? extends T4> source4,
        //              Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Publisher<? extends T7> source7,
        //              Function7<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? extends R> combiner)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          ObjectHelper.requireNonNull(source5, "source5 is null");
        //          ObjectHelper.requireNonNull(source6, "source6 is null");
        //          ObjectHelper.requireNonNull(source7, "source7 is null");
        //          return combineLatest(Functions.toFunction(combiner), source1, source2, source3, source4, source5, source6, source7);
        //      }


        //      public static <T1, T2, T3, T4, T5, T6, T7, T8, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              Publisher<? extends T3> source3, Publisher<? extends T4> source4,
        //              Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Publisher<? extends T7> source7, Publisher<? extends T8> source8,
        //              Function8<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? extends R> combiner)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          ObjectHelper.requireNonNull(source5, "source5 is null");
        //          ObjectHelper.requireNonNull(source6, "source6 is null");
        //          ObjectHelper.requireNonNull(source7, "source7 is null");
        //          ObjectHelper.requireNonNull(source8, "source8 is null");
        //          return combineLatest(Functions.toFunction(combiner), source1, source2, source3, source4, source5, source6, source7, source8);
        //      }

        //      public static <T1, T2, T3, T4, T5, T6, T7, T8, T9, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              Publisher<? extends T3> source3, Publisher<? extends T4> source4,
        //              Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Publisher<? extends T7> source7, Publisher<? extends T8> source8,
        //              Publisher<? extends T9> source9,
        //              Function9<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? super T9, ? extends R> combiner)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          ObjectHelper.requireNonNull(source5, "source5 is null");
        //          ObjectHelper.requireNonNull(source6, "source6 is null");
        //          ObjectHelper.requireNonNull(source7, "source7 is null");
        //          ObjectHelper.requireNonNull(source8, "source8 is null");
        //          ObjectHelper.requireNonNull(source9, "source9 is null");
        //          return combineLatest(Functions.toFunction(combiner), source1, source2, source3, source4, source5, source6, source7, source8, source9);
        //      }

        //      public static <T> Flowable<T> concat(Iterable<? extends Publisher<? extends T>> sources)
        //      {
        //          ObjectHelper.requireNonNull(sources, "sources is null");
        //          // unlike general sources, fromIterable can only throw on a boundary because it is consumed only there
        //          return fromIterable(sources).concatMapDelayError((Function)Functions.identity(), 2, false);
        //      }

        //      public static <T> Flowable<T> concat(Publisher<? extends Publisher<? extends T>> sources)
        //      {
        //          return concat(sources, bufferSize());
        //      }

        //      public static <T> Flowable<T> concat(Publisher<? extends Publisher<? extends T>> sources, int prefetch)
        //      {
        //          return fromPublisher(sources).concatMap((Function)Functions.identity(), prefetch);
        //      }

        //      public static <T> Flowable<T> concat(Publisher<? extends T> source1, Publisher<? extends T> source2)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          return concatArray(source1, source2);
        //      }

        //      public static <T> Flowable<T> concat(
        //              Publisher<? extends T> source1, Publisher<? extends T> source2,
        //              Publisher<? extends T> source3)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          return concatArray(source1, source2, source3);
        //      }


        //      public static <T> Flowable<T> concat(
        //              Publisher<? extends T> source1, Publisher<? extends T> source2,
        //              Publisher<? extends T> source3, Publisher<? extends T> source4)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          return concatArray(source1, source2, source3, source4);
        //      }


        //      public static <T> Flowable<T> concatArray(Publisher<? extends T>...sources)
        //      {
        //          if (sources.length == 0)
        //          {
        //              return empty();
        //          }
        //          else
        //          if (sources.length == 1)
        //          {
        //              return fromPublisher(sources[0]);
        //          }
        //          return RxJavaPlugins.onAssembly(new FlowableConcatArray<T>(sources, false));
        //      }


        //      public static <T> Flowable<T> concatArrayDelayError(Publisher<? extends T>...sources)
        //      {
        //          if (sources.length == 0)
        //          {
        //              return empty();
        //          }
        //          else
        //          if (sources.length == 1)
        //          {
        //              return fromPublisher(sources[0]);
        //          }
        //          return RxJavaPlugins.onAssembly(new FlowableConcatArray<T>(sources, true));
        //      }


        //      public static <T> Flowable<T> concatArrayEager(Publisher<? extends T>...sources)
        //      {
        //          return concatArrayEager(bufferSize(), bufferSize(), sources);
        //      }

        //      public static <T> Flowable<T> concatArrayEager(int maxConcurrency, int prefetch, Publisher<? extends T>...sources)
        //      {
        //          ObjectHelper.requireNonNull(sources, "sources is null");
        //          ObjectHelper.verifyPositive(maxConcurrency, "maxConcurrency");
        //          ObjectHelper.verifyPositive(prefetch, "prefetch");
        //          return RxJavaPlugins.onAssembly(new FlowableConcatMapEager(new FlowableFromArray(sources), Functions.identity(), maxConcurrency, prefetch, ErrorMode.IMMEDIATE));
        //      }

        //      public static <T> Flowable<T> concatArrayEagerDelayError(Publisher<? extends T>...sources)
        //      {
        //          return concatArrayEagerDelayError(bufferSize(), bufferSize(), sources);
        //      }

        //      public static <T> Flowable<T> concatArrayEagerDelayError(int maxConcurrency, int prefetch, Publisher<? extends T>...sources)
        //      {
        //          return fromArray(sources).concatMapEagerDelayError((Function)Functions.identity(), maxConcurrency, prefetch, true);
        //      }

        //      public static <T> Flowable<T> concatDelayError(Iterable<? extends Publisher<? extends T>> sources)
        //      {
        //          ObjectHelper.requireNonNull(sources, "sources is null");
        //          return fromIterable(sources).concatMapDelayError((Function)Functions.identity());
        //      }

        //      public static <T> Flowable<T> concatDelayError(Publisher<? extends Publisher<? extends T>> sources)
        //      {
        //          return concatDelayError(sources, bufferSize(), true);
        //      }


        //      public static <T> Flowable<T> concatDelayError(Publisher<? extends Publisher<? extends T>> sources, int prefetch, boolean tillTheEnd)
        //      {
        //          return fromPublisher(sources).concatMapDelayError((Function)Functions.identity(), prefetch, tillTheEnd);
        //      }

        //      public static <T> Flowable<T> concatEager(Publisher<? extends Publisher<? extends T>> sources)
        //      {
        //          return concatEager(sources, bufferSize(), bufferSize());
        //      }

        //      public static <T> Flowable<T> concatEager(Publisher<? extends Publisher<? extends T>> sources, int maxConcurrency, int prefetch)
        //      {
        //          ObjectHelper.requireNonNull(sources, "sources is null");
        //          ObjectHelper.verifyPositive(maxConcurrency, "maxConcurrency");
        //          ObjectHelper.verifyPositive(prefetch, "prefetch");
        //          return RxJavaPlugins.onAssembly(new FlowableConcatMapEagerPublisher(sources, Functions.identity(), maxConcurrency, prefetch, ErrorMode.IMMEDIATE));
        //      }

        //      public static <T> Flowable<T> concatEager(Iterable<? extends Publisher<? extends T>> sources)
        //      {
        //          return concatEager(sources, bufferSize(), bufferSize());
        //      }


        //      public static <T> Flowable<T> concatEager(Iterable<? extends Publisher<? extends T>> sources, int maxConcurrency, int prefetch)
        //      {
        //          ObjectHelper.requireNonNull(sources, "sources is null");
        //          ObjectHelper.verifyPositive(maxConcurrency, "maxConcurrency");
        //          ObjectHelper.verifyPositive(prefetch, "prefetch");
        //          return RxJavaPlugins.onAssembly(new FlowableConcatMapEager(new FlowableFromIterable(sources), Functions.identity(), maxConcurrency, prefetch, ErrorMode.IMMEDIATE));
        //      }

        //      public static <T> Flowable<T> create(FlowableOnSubscribe<T> source, BackpressureStrategy mode)
        //      {
        //          ObjectHelper.requireNonNull(source, "source is null");
        //          ObjectHelper.requireNonNull(mode, "mode is null");
        //          return RxJavaPlugins.onAssembly(new FlowableCreate<T>(source, mode));
        //      }


        //      public static <T> Flowable<T> defer(Callable<? extends Publisher<? extends T>> supplier)
        //      {
        //          ObjectHelper.requireNonNull(supplier, "supplier is null");
        //          return RxJavaPlugins.onAssembly(new FlowableDefer<T>(supplier));
        //      }

        //      public static <T> Flowable<T> empty()
        //      {
        //          return RxJavaPlugins.onAssembly((Flowable<T>)FlowableEmpty.INSTANCE);
        //      }

        //      public static <T> Flowable<T> error(Callable<? extends Throwable> supplier)
        //      {
        //          ObjectHelper.requireNonNull(supplier, "errorSupplier is null");
        //          return RxJavaPlugins.onAssembly(new FlowableError<T>(supplier));
        //      }

        //      public static <T> Flowable<T> error(final Throwable throwable)
        //      {
        //          ObjectHelper.requireNonNull(throwable, "throwable is null");
        //          return error(Functions.justCallable(throwable));
        //      }

        public static IFlowable<T> ToFlowable<T>(this IEnumerable<T> items)
        {
            return new FlowableFromEnumerable<T>(items);
        }

        //      public static <T> Flowable<T> fromCallable(Callable<? extends T> supplier)
        //      {
        //          ObjectHelper.requireNonNull(supplier, "supplier is null");
        //          return RxJavaPlugins.onAssembly(new FlowableFromCallable<T>(supplier));
        //      }


        //      public static <T> Flowable<T> fromFuture(Future<? extends T> future)
        //      {
        //          ObjectHelper.requireNonNull(future, "future is null");
        //          return RxJavaPlugins.onAssembly(new FlowableFromFuture<T>(future, 0L, null));
        //      }


        //      public static <T> Flowable<T> fromFuture(Future<? extends T> future, long timeout, TimeUnit unit)
        //      {
        //          ObjectHelper.requireNonNull(future, "future is null");
        //          ObjectHelper.requireNonNull(unit, "unit is null");
        //          return RxJavaPlugins.onAssembly(new FlowableFromFuture<T>(future, timeout, unit));
        //      }

        //      public static <T> Flowable<T> fromFuture(Future<? extends T> future, long timeout, TimeUnit unit, Scheduler scheduler)
        //      {
        //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
        //          return fromFuture((Future<T>)future, timeout, unit).subscribeOn(scheduler);
        //      }

        //      public static <T> Flowable<T> fromFuture(Future<? extends T> future, Scheduler scheduler)
        //      {
        //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
        //          return fromFuture((Future<T>)future).subscribeOn(scheduler);
        //      }

        //      public static <T> Flowable<T> fromIterable(Iterable<? extends T> source)
        //      {
        //          ObjectHelper.requireNonNull(source, "source is null");
        //          return RxJavaPlugins.onAssembly(new FlowableFromIterable<T>(source));
        //      }

        //      public static <T> Flowable<T> fromPublisher(final Publisher<? extends T> source)
        //      {
        //          if (source instanceof Flowable) {
        //              return RxJavaPlugins.onAssembly((Flowable<T>)source);
        //          }
        //          ObjectHelper.requireNonNull(source, "publisher is null");

        //          return RxJavaPlugins.onAssembly(new FlowableFromPublisher<T>(source));
        //      }

        //      public static <T> Flowable<T> generate(final Consumer<Emitter<T>> generator)
        //      {
        //          ObjectHelper.requireNonNull(generator, "generator is null");
        //          return generate(Functions.nullSupplier(),
        //                  FlowableInternalHelper.< T, Object > simpleGenerator(generator),
        //                  Functions.emptyConsumer());
        //      }

        //      public static <T, S> Flowable<T> generate(Callable<S> initialState, final BiConsumer<S, Emitter<T>> generator)
        //      {
        //          ObjectHelper.requireNonNull(generator, "generator is null");
        //          return generate(initialState, FlowableInternalHelper.< T, S > simpleBiGenerator(generator),
        //                  Functions.emptyConsumer());
        //      }

        //      public static <T, S> Flowable<T> generate(Callable<S> initialState, final BiConsumer<S, Emitter<T>> generator,
        //              Consumer<? super S> disposeState)
        //      {
        //          ObjectHelper.requireNonNull(generator, "generator is null");
        //          return generate(initialState, FlowableInternalHelper.< T, S > simpleBiGenerator(generator), disposeState);
        //      }

        //      public static <T, S> Flowable<T> generate(Callable<S> initialState, BiFunction<S, Emitter<T>, S> generator)
        //      {
        //          return generate(initialState, generator, Functions.emptyConsumer());
        //      }

        //      public static <T, S> Flowable<T> generate(Callable<S> initialState, BiFunction<S, Emitter<T>, S> generator, Consumer<? super S> disposeState)
        //      {
        //          ObjectHelper.requireNonNull(initialState, "initialState is null");
        //          ObjectHelper.requireNonNull(generator, "generator is null");
        //          ObjectHelper.requireNonNull(disposeState, "disposeState is null");
        //          return RxJavaPlugins.onAssembly(new FlowableGenerate<T, S>(initialState, generator, disposeState));
        //      }

        //      public static Flowable<Long> interval(long initialDelay, long period, TimeUnit unit)
        //      {
        //          return interval(initialDelay, period, unit, Schedulers.computation());
        //      }

        //      public static Flowable<Long> interval(long initialDelay, long period, TimeUnit unit, Scheduler scheduler)
        //      {
        //          ObjectHelper.requireNonNull(unit, "unit is null");
        //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
        //          return RxJavaPlugins.onAssembly(new FlowableInterval(Math.max(0L, initialDelay), Math.max(0L, period), unit, scheduler));
        //      }

        //      public static Flowable<Long> interval(long period, TimeUnit unit)
        //      {
        //          return interval(period, period, unit, Schedulers.computation());
        //      }

        //      public static Flowable<Long> interval(long period, TimeUnit unit, Scheduler scheduler)
        //      {
        //          return interval(period, period, unit, scheduler);
        //      }

        //      public static Flowable<Long> intervalRange(long start, long count, long initialDelay, long period, TimeUnit unit)
        //      {
        //          return intervalRange(start, count, initialDelay, period, unit, Schedulers.computation());
        //      }

        //      public static Flowable<Long> intervalRange(long start, long count, long initialDelay, long period, TimeUnit unit, Scheduler scheduler)
        //      {
        //          if (count < 0L)
        //          {
        //              throw new IllegalArgumentException("count >= 0 required but it was " + count);
        //          }
        //          if (count == 0L)
        //          {
        //              return Flowable.< Long > empty().delay(initialDelay, unit, scheduler);
        //          }

        //          long end = start + (count - 1);
        //          if (start > 0 && end < 0)
        //          {
        //              throw new IllegalArgumentException("Overflow! start + count is bigger than Long.MAX_VALUE");
        //          }
        //          ObjectHelper.requireNonNull(unit, "unit is null");
        //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");

        //          return RxJavaPlugins.onAssembly(new FlowableIntervalRange(start, end, Math.max(0L, initialDelay), Math.max(0L, period), unit, scheduler));
        //      }

        //      public static <T> Flowable<T> just(T item)
        //      {
        //          ObjectHelper.requireNonNull(item, "item is null");
        //          return RxJavaPlugins.onAssembly(new FlowableJust<T>(item));
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2)
        //      {
        //          ObjectHelper.requireNonNull(item1, "The first item is null");
        //          ObjectHelper.requireNonNull(item2, "The second item is null");

        //          return fromArray(item1, item2);
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3)
        //      {
        //          ObjectHelper.requireNonNull(item1, "The first item is null");
        //          ObjectHelper.requireNonNull(item2, "The second item is null");
        //          ObjectHelper.requireNonNull(item3, "The third item is null");

        //          return fromArray(item1, item2, item3);
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3, T item4)
        //      {
        //          ObjectHelper.requireNonNull(item1, "The first item is null");
        //          ObjectHelper.requireNonNull(item2, "The second item is null");
        //          ObjectHelper.requireNonNull(item3, "The third item is null");
        //          ObjectHelper.requireNonNull(item4, "The fourth item is null");

        //          return fromArray(item1, item2, item3, item4);
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3, T item4, T item5)
        //      {
        //          ObjectHelper.requireNonNull(item1, "The first item is null");
        //          ObjectHelper.requireNonNull(item2, "The second item is null");
        //          ObjectHelper.requireNonNull(item3, "The third item is null");
        //          ObjectHelper.requireNonNull(item4, "The fourth item is null");
        //          ObjectHelper.requireNonNull(item5, "The fifth item is null");

        //          return fromArray(item1, item2, item3, item4, item5);
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3, T item4, T item5, T item6)
        //      {
        //          ObjectHelper.requireNonNull(item1, "The first item is null");
        //          ObjectHelper.requireNonNull(item2, "The second item is null");
        //          ObjectHelper.requireNonNull(item3, "The third item is null");
        //          ObjectHelper.requireNonNull(item4, "The fourth item is null");
        //          ObjectHelper.requireNonNull(item5, "The fifth item is null");
        //          ObjectHelper.requireNonNull(item6, "The sixth item is null");

        //          return fromArray(item1, item2, item3, item4, item5, item6);
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3, T item4, T item5, T item6, T item7)
        //      {
        //          ObjectHelper.requireNonNull(item1, "The first item is null");
        //          ObjectHelper.requireNonNull(item2, "The second item is null");
        //          ObjectHelper.requireNonNull(item3, "The third item is null");
        //          ObjectHelper.requireNonNull(item4, "The fourth item is null");
        //          ObjectHelper.requireNonNull(item5, "The fifth item is null");
        //          ObjectHelper.requireNonNull(item6, "The sixth item is null");
        //          ObjectHelper.requireNonNull(item7, "The seventh item is null");

        //          return fromArray(item1, item2, item3, item4, item5, item6, item7);
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3, T item4, T item5, T item6, T item7, T item8)
        //      {
        //          ObjectHelper.requireNonNull(item1, "The first item is null");
        //          ObjectHelper.requireNonNull(item2, "The second item is null");
        //          ObjectHelper.requireNonNull(item3, "The third item is null");
        //          ObjectHelper.requireNonNull(item4, "The fourth item is null");
        //          ObjectHelper.requireNonNull(item5, "The fifth item is null");
        //          ObjectHelper.requireNonNull(item6, "The sixth item is null");
        //          ObjectHelper.requireNonNull(item7, "The seventh item is null");
        //          ObjectHelper.requireNonNull(item8, "The eighth item is null");

        //          return fromArray(item1, item2, item3, item4, item5, item6, item7, item8);
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3, T item4, T item5, T item6, T item7, T item8, T item9)
        //      {
        //          ObjectHelper.requireNonNull(item1, "The first item is null");
        //          ObjectHelper.requireNonNull(item2, "The second item is null");
        //          ObjectHelper.requireNonNull(item3, "The third item is null");
        //          ObjectHelper.requireNonNull(item4, "The fourth item is null");
        //          ObjectHelper.requireNonNull(item5, "The fifth item is null");
        //          ObjectHelper.requireNonNull(item6, "The sixth item is null");
        //          ObjectHelper.requireNonNull(item7, "The seventh item is null");
        //          ObjectHelper.requireNonNull(item8, "The eighth item is null");
        //          ObjectHelper.requireNonNull(item9, "The ninth is null");

        //          return fromArray(item1, item2, item3, item4, item5, item6, item7, item8, item9);
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3, T item4, T item5, T item6, T item7, T item8, T item9, T item10)
        //      {
        //          ObjectHelper.requireNonNull(item1, "The first item is null");
        //          ObjectHelper.requireNonNull(item2, "The second item is null");
        //          ObjectHelper.requireNonNull(item3, "The third item is null");
        //          ObjectHelper.requireNonNull(item4, "The fourth item is null");
        //          ObjectHelper.requireNonNull(item5, "The fifth item is null");
        //          ObjectHelper.requireNonNull(item6, "The sixth item is null");
        //          ObjectHelper.requireNonNull(item7, "The seventh item is null");
        //          ObjectHelper.requireNonNull(item8, "The eighth item is null");
        //          ObjectHelper.requireNonNull(item9, "The ninth item is null");
        //          ObjectHelper.requireNonNull(item10, "The tenth item is null");

        //          return fromArray(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10);
        //      }

        //      public static <T> Flowable<T> merge(Iterable<? extends Publisher<? extends T>> sources, int maxConcurrency, int bufferSize)
        //      {
        //          return fromIterable(sources).flatMap((Function)Functions.identity(), false, maxConcurrency, bufferSize);
        //      }

        //      public static <T> Flowable<T> mergeArray(int maxConcurrency, int bufferSize, Publisher<? extends T>...sources)
        //      {
        //          return fromArray(sources).flatMap((Function)Functions.identity(), false, maxConcurrency, bufferSize);
        //      }

        //      public static <T> Flowable<T> merge(Iterable<? extends Publisher<? extends T>> sources)
        //      {
        //          return fromIterable(sources).flatMap((Function)Functions.identity());
        //      }

        //      public static <T> Flowable<T> merge(Iterable<? extends Publisher<? extends T>> sources, int maxConcurrency)
        //      {
        //          return fromIterable(sources).flatMap((Function)Functions.identity(), maxConcurrency);
        //      }

        //      public static <T> Flowable<T> merge(Publisher<? extends Publisher<? extends T>> sources)
        //      {
        //          return merge(sources, bufferSize());
        //      }

        //      public static <T> Flowable<T> merge(Publisher<? extends Publisher<? extends T>> sources, int maxConcurrency)
        //      {
        //          return fromPublisher(sources).flatMap((Function)Functions.identity(), maxConcurrency);
        //      }

        //      public static <T> Flowable<T> mergeArray(Publisher<? extends T>...sources)
        //      {
        //          return fromArray(sources).flatMap((Function)Functions.identity(), sources.length);
        //      }

        //      public static <T> Flowable<T> merge(Publisher<? extends T> source1, Publisher<? extends T> source2)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          return fromArray(source1, source2).flatMap((Function)Functions.identity(), false, 2);
        //      }

        //      public static <T> Flowable<T> merge(Publisher<? extends T> source1, Publisher<? extends T> source2, Publisher<? extends T> source3)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          return fromArray(source1, source2, source3).flatMap((Function)Functions.identity(), false, 3);
        //      }

        //      public static <T> Flowable<T> merge(
        //              Publisher<? extends T> source1, Publisher<? extends T> source2,
        //              Publisher<? extends T> source3, Publisher<? extends T> source4)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          return fromArray(source1, source2, source3, source4).flatMap((Function)Functions.identity(), false, 4);
        //      }

        //      public static <T> Flowable<T> mergeDelayError(Iterable<? extends Publisher<? extends T>> sources)
        //      {
        //          return fromIterable(sources).flatMap((Function)Functions.identity(), true);
        //      }

        //      public static <T> Flowable<T> mergeDelayError(Iterable<? extends Publisher<? extends T>> sources, int maxConcurrency, int bufferSize)
        //      {
        //          return fromIterable(sources).flatMap((Function)Functions.identity(), true, maxConcurrency, bufferSize);
        //      }

        //      public static <T> Flowable<T> mergeArrayDelayError(int maxConcurrency, int bufferSize, Publisher<? extends T>...sources)
        //      {
        //          return fromArray(sources).flatMap((Function)Functions.identity(), true, maxConcurrency, bufferSize);
        //      }

        //      public static <T> Flowable<T> mergeDelayError(Iterable<? extends Publisher<? extends T>> sources, int maxConcurrency)
        //      {
        //          return fromIterable(sources).flatMap((Function)Functions.identity(), true, maxConcurrency);
        //      }

        //      public static <T> Flowable<T> mergeDelayError(Publisher<? extends Publisher<? extends T>> sources)
        //      {
        //          return mergeDelayError(sources, bufferSize());
        //      }

        //      public static <T> Flowable<T> mergeDelayError(Publisher<? extends Publisher<? extends T>> sources, int maxConcurrency)
        //      {
        //          return fromPublisher(sources).flatMap((Function)Functions.identity(), true, maxConcurrency);
        //      }

        //      public static <T> Flowable<T> mergeArrayDelayError(Publisher<? extends T>...sources)
        //      {
        //          return fromArray(sources).flatMap((Function)Functions.identity(), true, sources.length);
        //      }

        //      public static <T> Flowable<T> mergeDelayError(Publisher<? extends T> source1, Publisher<? extends T> source2)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          return fromArray(source1, source2).flatMap((Function)Functions.identity(), true, 2);
        //      }

        //      public static <T> Flowable<T> mergeDelayError(Publisher<? extends T> source1, Publisher<? extends T> source2, Publisher<? extends T> source3)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          return fromArray(source1, source2, source3).flatMap((Function)Functions.identity(), true, 3);
        //      }

        //      public static <T> Flowable<T> mergeDelayError(
        //              Publisher<? extends T> source1, Publisher<? extends T> source2,
        //              Publisher<? extends T> source3, Publisher<? extends T> source4)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          return fromArray(source1, source2, source3, source4).flatMap((Function)Functions.identity(), true, 4);
        //      }

        //      public static <T> Flowable<T> never()
        //      {
        //          return RxJavaPlugins.onAssembly((Flowable<T>)FlowableNever.INSTANCE);
        //      }

        //      public static Flowable<Integer> range(int start, int count)
        //      {
        //          if (count < 0)
        //          {
        //              throw new IllegalArgumentException("count >= 0 required but it was " + count);
        //          }
        //          else
        //          if (count == 0)
        //          {
        //              return empty();
        //          }
        //          else
        //          if (count == 1)
        //          {
        //              return just(start);
        //          }
        //          else
        //          if ((long)start + (count - 1) > Integer.MAX_VALUE)
        //          {
        //              throw new IllegalArgumentException("Integer overflow");
        //          }
        //          return RxJavaPlugins.onAssembly(new FlowableRange(start, count));
        //      }

        //      public static Flowable<Long> rangeLong(long start, long count)
        //      {
        //          if (count < 0)
        //          {
        //              throw new IllegalArgumentException("count >= 0 required but it was " + count);
        //          }

        //          if (count == 0)
        //          {
        //              return empty();
        //          }

        //          if (count == 1)
        //          {
        //              return just(start);
        //          }

        //          long end = start + (count - 1);
        //          if (start > 0 && end < 0)
        //          {
        //              throw new IllegalArgumentException("Overflow! start + count is bigger than Long.MAX_VALUE");
        //          }

        //          return RxJavaPlugins.onAssembly(new FlowableRangeLong(start, count));
        //      }

        //      public static <T> Single<Boolean> sequenceEqual(Publisher<? extends T> source1, Publisher<? extends T> source2)
        //      {
        //          return sequenceEqual(source1, source2, ObjectHelper.equalsPredicate(), bufferSize());
        //      }

        //      public static <T> Single<Boolean> sequenceEqual(Publisher<? extends T> source1, Publisher<? extends T> source2,
        //              BiPredicate<? super T, ? super T> isEqual)
        //      {
        //          return sequenceEqual(source1, source2, isEqual, bufferSize());
        //      }

        //      public static <T> Single<Boolean> sequenceEqual(Publisher<? extends T> source1, Publisher<? extends T> source2,
        //              BiPredicate<? super T, ? super T> isEqual, int bufferSize)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(isEqual, "isEqual is null");
        //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
        //          return RxJavaPlugins.onAssembly(new FlowableSequenceEqualSingle<T>(source1, source2, isEqual, bufferSize));
        //      }

        //      public static <T> Single<Boolean> sequenceEqual(Publisher<? extends T> source1, Publisher<? extends T> source2, int bufferSize)
        //      {
        //          return sequenceEqual(source1, source2, ObjectHelper.equalsPredicate(), bufferSize);
        //      }

        //      public static <T> Flowable<T> switchOnNext(Publisher<? extends Publisher<? extends T>> sources, int bufferSize)
        //      {
        //          return fromPublisher(sources).switchMap((Function)Functions.identity(), bufferSize);
        //      }

        //      public static <T> Flowable<T> switchOnNext(Publisher<? extends Publisher<? extends T>> sources)
        //      {
        //          return fromPublisher(sources).switchMap((Function)Functions.identity());
        //      }

        //      public static <T> Flowable<T> switchOnNextDelayError(Publisher<? extends Publisher<? extends T>> sources)
        //      {
        //          return switchOnNextDelayError(sources, bufferSize());
        //      }

        //      public static <T> Flowable<T> switchOnNextDelayError(Publisher<? extends Publisher<? extends T>> sources, int prefetch)
        //      {
        //          return fromPublisher(sources).switchMapDelayError(Functions.< Publisher <? extends T >> identity(), prefetch);
        //      }

        //      public static Flowable<Long> timer(long delay, TimeUnit unit)
        //      {
        //          return timer(delay, unit, Schedulers.computation());
        //      }

        //      public static Flowable<Long> timer(long delay, TimeUnit unit, Scheduler scheduler)
        //      {
        //          ObjectHelper.requireNonNull(unit, "unit is null");
        //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");

        //          return RxJavaPlugins.onAssembly(new FlowableTimer(Math.max(0L, delay), unit, scheduler));
        //      }

        //      public static <T> Flowable<T> unsafeCreate(Publisher<T> onSubscribe)
        //      {
        //          ObjectHelper.requireNonNull(onSubscribe, "onSubscribe is null");
        //          if (onSubscribe instanceof Flowable) {
        //              throw new IllegalArgumentException("unsafeCreate(Flowable) should be upgraded");
        //          }
        //          return RxJavaPlugins.onAssembly(new FlowableFromPublisher<T>(onSubscribe));
        //      }

        //      public static <T, D> Flowable<T> Using(Callable<? extends D> resourceSupplier,
        //              Function<? super D, ? extends Publisher<? extends T>> sourceSupplier, Consumer<? super D> resourceDisposer) {
        //          return using (resourceSupplier, sourceSupplier, resourceDisposer, true);
        //      }

        //      public static <T, D> Flowable<T> Using(Callable<? extends D> resourceSupplier,
        //              Function<? super D, ? extends Publisher<? extends T>> sourceSupplier,
        //                      Consumer<? super D> resourceDisposer, boolean eager)
        //      {
        //          ObjectHelper.requireNonNull(resourceSupplier, "resourceSupplier is null");
        //          ObjectHelper.requireNonNull(sourceSupplier, "sourceSupplier is null");
        //          ObjectHelper.requireNonNull(resourceDisposer, "disposer is null");
        //          return RxJavaPlugins.onAssembly(new FlowableUsing<T, D>(resourceSupplier, sourceSupplier, resourceDisposer, eager));
        //      }


        //      public static <T, R> Flowable<R> zip(Iterable<? extends Publisher<? extends T>> sources, Function<? super Object[], ? extends R> zipper)
        //      {
        //          ObjectHelper.requireNonNull(zipper, "zipper is null");
        //          ObjectHelper.requireNonNull(sources, "sources is null");
        //          return RxJavaPlugins.onAssembly(new FlowableZip<T, R>(null, sources, zipper, bufferSize(), false));
        //      }

        //      public static <T, R> Flowable<R> zip(Publisher<? extends Publisher<? extends T>> sources,
        //              final Function<? super Object[], ? extends R> zipper)
        //      {
        //          ObjectHelper.requireNonNull(zipper, "zipper is null");
        //          return fromPublisher(sources).toList().flatMapPublisher((Function)FlowableInternalHelper.< T, R > zipIterable(zipper));
        //      }

        //      public static <T1, T2, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              BiFunction<? super T1, ? super T2, ? extends R> zipper)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          return zipArray(Functions.toFunction(zipper), false, bufferSize(), source1, source2);
        //      }

        //      public static <T1, T2, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              BiFunction<? super T1, ? super T2, ? extends R> zipper, boolean delayError)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          return zipArray(Functions.toFunction(zipper), delayError, bufferSize(), source1, source2);
        //      }

        //      public static <T1, T2, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              BiFunction<? super T1, ? super T2, ? extends R> zipper, boolean delayError, int bufferSize)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          return zipArray(Functions.toFunction(zipper), delayError, bufferSize, source1, source2);
        //      }

        //      public static <T1, T2, T3, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2, Publisher<? extends T3> source3,
        //              Function3<? super T1, ? super T2, ? super T3, ? extends R> zipper)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          return zipArray(Functions.toFunction(zipper), false, bufferSize(), source1, source2, source3);
        //      }

        //      public static <T1, T2, T3, T4, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2, Publisher<? extends T3> source3,
        //              Publisher<? extends T4> source4,
        //              Function4<? super T1, ? super T2, ? super T3, ? super T4, ? extends R> zipper)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          return zipArray(Functions.toFunction(zipper), false, bufferSize(), source1, source2, source3, source4);
        //      }

        //      public static <T1, T2, T3, T4, T5, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2, Publisher<? extends T3> source3,
        //              Publisher<? extends T4> source4, Publisher<? extends T5> source5,
        //              Function5<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? extends R> zipper)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          ObjectHelper.requireNonNull(source5, "source5 is null");
        //          return zipArray(Functions.toFunction(zipper), false, bufferSize(), source1, source2, source3, source4, source5);
        //      }

        //      public static <T1, T2, T3, T4, T5, T6, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2, Publisher<? extends T3> source3,
        //              Publisher<? extends T4> source4, Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Function6<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? extends R> zipper)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          ObjectHelper.requireNonNull(source5, "source5 is null");
        //          ObjectHelper.requireNonNull(source6, "source6 is null");
        //          return zipArray(Functions.toFunction(zipper), false, bufferSize(), source1, source2, source3, source4, source5, source6);
        //      }

        //      public static <T1, T2, T3, T4, T5, T6, T7, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2, Publisher<? extends T3> source3,
        //              Publisher<? extends T4> source4, Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Publisher<? extends T7> source7,
        //              Function7<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? extends R> zipper)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          ObjectHelper.requireNonNull(source5, "source5 is null");
        //          ObjectHelper.requireNonNull(source6, "source6 is null");
        //          ObjectHelper.requireNonNull(source7, "source7 is null");
        //          return zipArray(Functions.toFunction(zipper), false, bufferSize(), source1, source2, source3, source4, source5, source6, source7);
        //      }


        //      public static <T1, T2, T3, T4, T5, T6, T7, T8, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2, Publisher<? extends T3> source3,
        //              Publisher<? extends T4> source4, Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Publisher<? extends T7> source7, Publisher<? extends T8> source8,
        //              Function8<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? extends R> zipper)
        //      {
        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          ObjectHelper.requireNonNull(source5, "source5 is null");
        //          ObjectHelper.requireNonNull(source6, "source6 is null");
        //          ObjectHelper.requireNonNull(source7, "source7 is null");
        //          ObjectHelper.requireNonNull(source8, "source8 is null");
        //          return zipArray(Functions.toFunction(zipper), false, bufferSize(), source1, source2, source3, source4, source5, source6, source7, source8);
        //      }

        //      public static <T1, T2, T3, T4, T5, T6, T7, T8, T9, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2, Publisher<? extends T3> source3,
        //              Publisher<? extends T4> source4, Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Publisher<? extends T7> source7, Publisher<? extends T8> source8, Publisher<? extends T9> source9,
        //              Function9<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? super T9, ? extends R> zipper)
        //      {

        //          ObjectHelper.requireNonNull(source1, "source1 is null");
        //          ObjectHelper.requireNonNull(source2, "source2 is null");
        //          ObjectHelper.requireNonNull(source3, "source3 is null");
        //          ObjectHelper.requireNonNull(source4, "source4 is null");
        //          ObjectHelper.requireNonNull(source5, "source5 is null");
        //          ObjectHelper.requireNonNull(source6, "source6 is null");
        //          ObjectHelper.requireNonNull(source7, "source7 is null");
        //          ObjectHelper.requireNonNull(source8, "source8 is null");
        //          ObjectHelper.requireNonNull(source9, "source9 is null");
        //          return zipArray(Functions.toFunction(zipper), false, bufferSize(), source1, source2, source3, source4, source5, source6, source7, source8, source9);
        //      }


        //      public static <T, R> Flowable<R> zipArray(Function<? super Object[], ? extends R> zipper,
        //              boolean delayError, int bufferSize, Publisher<? extends T>...sources)
        //      {
        //          if (sources.length == 0)
        //          {
        //              return empty();
        //          }
        //          ObjectHelper.requireNonNull(zipper, "zipper is null");
        //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
        //          return RxJavaPlugins.onAssembly(new FlowableZip<T, R>(sources, null, zipper, bufferSize, delayError));
        //      }

        //      public static <T, R> Flowable<R> zipIterable(Iterable<? extends Publisher<? extends T>> sources,
        //              Function<? super Object[], ? extends R> zipper, boolean delayError,
        //              int bufferSize)
        //      {
        //          ObjectHelper.requireNonNull(zipper, "zipper is null");
        //          ObjectHelper.requireNonNull(sources, "sources is null");
        //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
        //          return RxJavaPlugins.onAssembly(new FlowableZip<T, R>(null, sources, zipper, bufferSize, delayError));
        //      }
    }

    //      public static int bufferSize()
    //      {
    //          return BUFFER_SIZE;
    //      }


    //      //// ***************************************************************************************************
    //      //// Instance operators
    //      //// ***************************************************************************************************

    //      public final Single<Boolean> All(Predicate<? super T> predicate)    
    //{
    //          ObjectHelper.requireNonNull(predicate, "predicate is null");
    //          return RxJavaPlugins.onAssembly(new FlowableAllSingle<T>(this, predicate));
    //      }

    //      public final Flowable<T> ambWith(Publisher<? extends T> other)
    //{
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return ambArray(this, other);
    //      }

    //      public final Single<Boolean> any(Predicate<? super T> predicate)
    //{
    //          ObjectHelper.requireNonNull(predicate, "predicate is null");
    //          return RxJavaPlugins.onAssembly(new FlowableAnySingle<T>(this, predicate));
    //      }

    //      public final<R> R As(@NonNull FlowableConverter<T, ? extends R> converter)
    //      {
    //          return ObjectHelper.requireNonNull(converter, "converter is null").apply(this);
    //      }

    //      public final T blockingFirst()
    //      {
    //          BlockingFirstSubscriber<T> s = new BlockingFirstSubscriber<T>();
    //          subscribe(s);
    //          T v = s.blockingGet();
    //          if (v != null)
    //          {
    //              return v;
    //          }
    //          throw new NoSuchElementException();
    //      }

    //      public final T blockingFirst(T defaultItem)
    //      {
    //          BlockingFirstSubscriber<T> s = new BlockingFirstSubscriber<T>();
    //          subscribe(s);
    //          T v = s.blockingGet();
    //          return v != null ? v : defaultItem;
    //      }

    //      public final void blockingForEach(Consumer<? super T> onNext)
    //      {
    //          Iterator<T> it = blockingIterable().iterator();
    //          while (it.hasNext())
    //          {
    //              try
    //              {
    //                  onNext.accept(it.next());
    //              }
    //              catch (Throwable e)
    //              {
    //                  Exceptions.throwIfFatal(e);
    //                  ((Disposable)it).dispose();
    //                  throw ExceptionHelper.wrapOrThrow(e);
    //              }
    //          }
    //      }

    //      public final Iterable<T> blockingIterable()
    //{
    //          return blockingIterable(bufferSize());
    //      }

    //      public final Iterable<T> blockingIterable(int bufferSize)
    //{
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          return new BlockingFlowableIterable<T>(this, bufferSize);
    //      }

    //      public final T blockingLast()
    //      {
    //          BlockingLastSubscriber<T> s = new BlockingLastSubscriber<T>();
    //          subscribe(s);
    //          T v = s.blockingGet();
    //          if (v != null)
    //          {
    //              return v;
    //          }
    //          throw new NoSuchElementException();
    //      }

    //      public final T blockingLast(T defaultItem)
    //      {
    //          BlockingLastSubscriber<T> s = new BlockingLastSubscriber<T>();
    //          subscribe(s);
    //          T v = s.blockingGet();
    //          return v != null ? v : defaultItem;
    //      }

    //      public final Iterable<T> blockingLatest()
    //      {
    //          return new BlockingFlowableLatest<T>(this);
    //      }

    //      public final Iterable<T> blockingMostRecent(T initialItem)
    //      {
    //          return new BlockingFlowableMostRecent<T>(this, initialItem);
    //      }

    //      public final Iterable<T> blockingNext()
    //      {
    //          return new BlockingFlowableNext<T>(this);
    //      }

    //      public final T blockingSingle()
    //      {
    //          return singleOrError().blockingGet();
    //      }

    //      public final T blockingSingle(T defaultItem)
    //      {
    //          return single(defaultItem).blockingGet();
    //      }

    //      public final Future<T> toFuture()
    //      {
    //          return subscribeWith(new FutureSubscriber<T>());
    //      }

    //      public final void blockingSubscribe()
    //      {
    //          FlowableBlockingSubscribe.subscribe(this);
    //      }

    //      public final void blockingSubscribe(Consumer<? super T> onNext)
    //      {
    //          FlowableBlockingSubscribe.subscribe(this, onNext, Functions.ON_ERROR_MISSING, Functions.EMPTY_ACTION);
    //      }

    //      public final void blockingSubscribe(Consumer<? super T> onNext, int bufferSize)
    //      {
    //          FlowableBlockingSubscribe.subscribe(this, onNext, Functions.ON_ERROR_MISSING, Functions.EMPTY_ACTION, bufferSize);
    //      }

    //      public final void blockingSubscribe(Consumer<? super T> onNext, Consumer<? super Throwable> onError)
    //      {
    //          FlowableBlockingSubscribe.subscribe(this, onNext, onError, Functions.EMPTY_ACTION);
    //      }

    //      public final void blockingSubscribe(Consumer<? super T> onNext, Consumer<? super Throwable> onError,
    //          int bufferSize)
    //      {
    //          FlowableBlockingSubscribe.subscribe(this, onNext, onError, Functions.EMPTY_ACTION, bufferSize);
    //      }

    //      public final void blockingSubscribe(Consumer<? super T> onNext, Consumer<? super Throwable> onError, Action onComplete)
    //      {
    //          FlowableBlockingSubscribe.subscribe(this, onNext, onError, onComplete);
    //      }

    //      public final void blockingSubscribe(Consumer<? super T> onNext, Consumer<? super Throwable> onError, Action onComplete,
    //          int bufferSize)
    //      {
    //          FlowableBlockingSubscribe.subscribe(this, onNext, onError, onComplete, bufferSize);
    //      }

    //      public final void blockingSubscribe(Subscriber<? super T> subscriber)
    //      {
    //          FlowableBlockingSubscribe.subscribe(this, subscriber);
    //      }

    //      public final Flowable<List<T>> buffer(int count)
    //      {
    //          return buffer(count, count);
    //      }

    //      public final Flowable<List<T>> buffer(int count, int skip)
    //      {
    //          return buffer(count, skip, ArrayListSupplier.< T > asCallable());
    //      }

    //      public final<U extends Collection<? super T>> Flowable<U> buffer(int count, int skip, Callable<U> bufferSupplier)
    //      {
    //          ObjectHelper.verifyPositive(count, "count");
    //          ObjectHelper.verifyPositive(skip, "skip");
    //          ObjectHelper.requireNonNull(bufferSupplier, "bufferSupplier is null");
    //          return RxJavaPlugins.onAssembly(new FlowableBuffer<T, U>(this, count, skip, bufferSupplier));
    //      }

    //      public final<U extends Collection<? super T>> Flowable<U> buffer(int count, Callable<U> bufferSupplier)
    //      {
    //          return buffer(count, count, bufferSupplier);
    //      }

    //      public final Flowable<List<T>> buffer(long timespan, long timeskip, TimeUnit unit)
    //      {
    //          return buffer(timespan, timeskip, unit, Schedulers.computation(), ArrayListSupplier.< T > asCallable());
    //      }

    //      public final Flowable<List<T>> buffer(long timespan, long timeskip, TimeUnit unit, Scheduler scheduler)
    //      {
    //          return buffer(timespan, timeskip, unit, scheduler, ArrayListSupplier.< T > asCallable());
    //      }

    //      public final<U extends Collection<? super T>> Flowable<U> buffer(long timespan, long timeskip, TimeUnit unit,
    //              Scheduler scheduler, Callable<U> bufferSupplier)
    //      {
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          ObjectHelper.requireNonNull(bufferSupplier, "bufferSupplier is null");
    //          return RxJavaPlugins.onAssembly(new FlowableBufferTimed<T, U>(this, timespan, timeskip, unit, scheduler, bufferSupplier, Integer.MAX_VALUE, false));
    //      }

    //      public final Flowable<List<T>> buffer(long timespan, TimeUnit unit)
    //      {
    //          return buffer(timespan, unit, Schedulers.computation(), Integer.MAX_VALUE);
    //      }

    //      public final Flowable<List<T>> buffer(long timespan, TimeUnit unit, int count)
    //      {
    //          return buffer(timespan, unit, Schedulers.computation(), count);
    //      }

    //      public final Flowable<List<T>> buffer(long timespan, TimeUnit unit, Scheduler scheduler, int count)
    //      {
    //          return buffer(timespan, unit, scheduler, count, ArrayListSupplier.< T > asCallable(), false);
    //      }

    //      public final<U extends Collection<? super T>> Flowable<U> buffer(
    //              long timespan, TimeUnit unit,
    //              Scheduler scheduler, int count,
    //              Callable<U> bufferSupplier,
    //              boolean restartTimerOnMaxSize)
    //      {
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          ObjectHelper.requireNonNull(bufferSupplier, "bufferSupplier is null");
    //          ObjectHelper.verifyPositive(count, "count");
    //          return RxJavaPlugins.onAssembly(new FlowableBufferTimed<T, U>(this, timespan, timespan, unit, scheduler, bufferSupplier, count, restartTimerOnMaxSize));
    //      }

    //      public final Flowable<List<T>> buffer(long timespan, TimeUnit unit, Scheduler scheduler)
    //      {
    //          return buffer(timespan, unit, scheduler, Integer.MAX_VALUE, ArrayListSupplier.< T > asCallable(), false);
    //      }

    //      public final<TOpening, TClosing> Flowable<List<T>> buffer(
    //              Flowable<? extends TOpening> openingIndicator,
    //              Function<? super TOpening, ? extends Publisher<? extends TClosing>> closingIndicator)
    //      {
    //          return buffer(openingIndicator, closingIndicator, ArrayListSupplier.< T > asCallable());
    //      }

    //      public final<TOpening, TClosing, U extends Collection<? super T>> Flowable<U> buffer(
    //              Flowable<? extends TOpening> openingIndicator,
    //              Function<? super TOpening, ? extends Publisher<? extends TClosing>> closingIndicator,
    //              Callable<U> bufferSupplier)
    //      {
    //          ObjectHelper.requireNonNull(openingIndicator, "openingIndicator is null");
    //          ObjectHelper.requireNonNull(closingIndicator, "closingIndicator is null");
    //          ObjectHelper.requireNonNull(bufferSupplier, "bufferSupplier is null");
    //          return RxJavaPlugins.onAssembly(new FlowableBufferBoundary<T, U, TOpening, TClosing>(this, openingIndicator, closingIndicator, bufferSupplier));
    //      }

    //      public final<B> Flowable<List<T>> buffer(Publisher<B> boundaryIndicator)
    //      {
    //          return buffer(boundaryIndicator, ArrayListSupplier.< T > asCallable());
    //      }

    //      public final<B> Flowable<List<T>> buffer(Publisher<B> boundaryIndicator, final int initialCapacity)
    //      {
    //          ObjectHelper.verifyPositive(initialCapacity, "initialCapacity");
    //          return buffer(boundaryIndicator, Functions.< T > createArrayList(initialCapacity));
    //      }

    //      public final<B, U extends Collection<? super T>> Flowable<U> buffer(Publisher<B> boundaryIndicator, Callable<U> bufferSupplier)
    //      {
    //          ObjectHelper.requireNonNull(boundaryIndicator, "boundaryIndicator is null");
    //          ObjectHelper.requireNonNull(bufferSupplier, "bufferSupplier is null");
    //          return RxJavaPlugins.onAssembly(new FlowableBufferExactBoundary<T, U, B>(this, boundaryIndicator, bufferSupplier));
    //      }

    //      public final<B> Flowable<List<T>> buffer(Callable<? extends Publisher<B>> boundaryIndicatorSupplier)
    //      {
    //          return buffer(boundaryIndicatorSupplier, ArrayListSupplier.< T > asCallable());
    //      }

    //      public final<B, U extends Collection<? super T>> Flowable<U> buffer(Callable<? extends Publisher<B>> boundaryIndicatorSupplier,
    //              Callable<U> bufferSupplier)
    //      {
    //          ObjectHelper.requireNonNull(boundaryIndicatorSupplier, "boundaryIndicatorSupplier is null");
    //          ObjectHelper.requireNonNull(bufferSupplier, "bufferSupplier is null");
    //          return RxJavaPlugins.onAssembly(new FlowableBufferBoundarySupplier<T, U, B>(this, boundaryIndicatorSupplier, bufferSupplier));
    //      }

    //      public final Flowable<T> cache()
    //      {
    //          return cacheWithInitialCapacity(16);
    //      }

    //      public final Flowable<T> cacheWithInitialCapacity(int initialCapacity)
    //      {
    //          ObjectHelper.verifyPositive(initialCapacity, "initialCapacity");
    //          return RxJavaPlugins.onAssembly(new FlowableCache<T>(this, initialCapacity));
    //      }

    //      public final<U> Flowable<U> cast(final Class<U> clazz)
    //      {
    //          ObjectHelper.requireNonNull(clazz, "clazz is null");
    //          return map(Functions.castFunction(clazz));
    //      }


    //      public final<U> Single<U> collect(Callable<? extends U> initialItemSupplier, BiConsumer<? super U, ? super T> collector)
    //      {
    //          ObjectHelper.requireNonNull(initialItemSupplier, "initialItemSupplier is null");
    //          ObjectHelper.requireNonNull(collector, "collector is null");
    //          return RxJavaPlugins.onAssembly(new FlowableCollectSingle<T, U>(this, initialItemSupplier, collector));
    //      }

    //      public final<U> Single<U> collectInto(final U initialItem, BiConsumer<? super U, ? super T> collector)
    //      {
    //          ObjectHelper.requireNonNull(initialItem, "initialItem is null");
    //          return collect(Functions.justCallable(initialItem), collector);
    //      }

    //      public final<R> Flowable<R> compose(FlowableTransformer<? super T, ? extends R> composer)
    //      {
    //          return fromPublisher(((FlowableTransformer<T, R>)ObjectHelper.requireNonNull(composer, "composer is null")).apply(this));
    //      }

    //      public final<R> Flowable<R> concatMap(Function<? super T, ? extends Publisher<? extends R>> mapper)
    //      {
    //          return concatMap(mapper, 2);
    //      }

    //      public final<R> Flowable<R> concatMap(Function<? super T, ? extends Publisher<? extends R>> mapper, int prefetch)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(prefetch, "prefetch");
    //          if (this instanceof ScalarCallable) {
    //              @SuppressWarnings("unchecked")

    //              T v = ((ScalarCallable<T>)this).call();
    //              if (v == null)
    //              {
    //                  return empty();
    //              }
    //              return FlowableScalarXMap.scalarXMap(v, mapper);
    //          }
    //          return RxJavaPlugins.onAssembly(new FlowableConcatMap<T, R>(this, mapper, prefetch, ErrorMode.IMMEDIATE));
    //      }

    //      public final Completable concatMapCompletable(Function<? super T, ? extends CompletableSource> mapper)
    //      {
    //          return concatMapCompletable(mapper, 2);
    //      }

    //      public final Completable concatMapCompletable(Function<? super T, ? extends CompletableSource> mapper, int prefetch)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(prefetch, "prefetch");
    //          return RxJavaPlugins.onAssembly(new FlowableConcatMapCompletable<T>(this, mapper, ErrorMode.IMMEDIATE, prefetch));
    //      }

    //      public final Completable concatMapCompletableDelayError(Function<? super T, ? extends CompletableSource> mapper)
    //      {
    //          return concatMapCompletableDelayError(mapper, true, 2);
    //      }

    //      public final Completable concatMapCompletableDelayError(Function<? super T, ? extends CompletableSource> mapper, boolean tillTheEnd)
    //      {
    //          return concatMapCompletableDelayError(mapper, tillTheEnd, 2);
    //      }

    //      public final Completable concatMapCompletableDelayError(Function<? super T, ? extends CompletableSource> mapper, boolean tillTheEnd, int prefetch)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(prefetch, "prefetch");
    //          return RxJavaPlugins.onAssembly(new FlowableConcatMapCompletable<T>(this, mapper, tillTheEnd ? ErrorMode.END : ErrorMode.BOUNDARY, prefetch));
    //      }

    //      public final<R> Flowable<R> concatMapDelayError(Function<? super T, ? extends Publisher<? extends R>> mapper)
    //      {
    //          return concatMapDelayError(mapper, 2, true);
    //      }

    //      public final<R> Flowable<R> concatMapDelayError(Function<? super T, ? extends Publisher<? extends R>> mapper,
    //              int prefetch, boolean tillTheEnd)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(prefetch, "prefetch");
    //          if (this instanceof ScalarCallable) {
    //              @SuppressWarnings("unchecked")

    //              T v = ((ScalarCallable<T>)this).call();
    //              if (v == null)
    //              {
    //                  return empty();
    //              }
    //              return FlowableScalarXMap.scalarXMap(v, mapper);
    //          }
    //          return RxJavaPlugins.onAssembly(new FlowableConcatMap<T, R>(this, mapper, prefetch, tillTheEnd ? ErrorMode.END : ErrorMode.BOUNDARY));
    //      }

    //      public final<R> Flowable<R> concatMapEager(Function<? super T, ? extends Publisher<? extends R>> mapper)
    //      {
    //          return concatMapEager(mapper, bufferSize(), bufferSize());
    //      }

    //      public final<R> Flowable<R> concatMapEager(Function<? super T, ? extends Publisher<? extends R>> mapper,
    //              int maxConcurrency, int prefetch)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(maxConcurrency, "maxConcurrency");
    //          ObjectHelper.verifyPositive(prefetch, "prefetch");
    //          return RxJavaPlugins.onAssembly(new FlowableConcatMapEager<T, R>(this, mapper, maxConcurrency, prefetch, ErrorMode.IMMEDIATE));
    //      }

    //      public final<R> Flowable<R> concatMapEagerDelayError(Function<? super T, ? extends Publisher<? extends R>> mapper,
    //              boolean tillTheEnd)
    //      {
    //          return concatMapEagerDelayError(mapper, bufferSize(), bufferSize(), tillTheEnd);
    //      }

    //      public final<R> Flowable<R> concatMapEagerDelayError(Function<? super T, ? extends Publisher<? extends R>> mapper,
    //              int maxConcurrency, int prefetch, boolean tillTheEnd)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(maxConcurrency, "maxConcurrency");
    //          ObjectHelper.verifyPositive(prefetch, "prefetch");
    //          return RxJavaPlugins.onAssembly(new FlowableConcatMapEager<T, R>(this, mapper, maxConcurrency, prefetch, tillTheEnd ? ErrorMode.END : ErrorMode.BOUNDARY));
    //      }

    //      public final<U> Flowable<U> concatMapIterable(Function<? super T, ? extends Iterable<? extends U>> mapper)
    //      {
    //          return concatMapIterable(mapper, 2);
    //      }

    //      public final<U> Flowable<U> concatMapIterable(final Function<? super T, ? extends Iterable<? extends U>> mapper, int prefetch)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(prefetch, "prefetch");
    //          return RxJavaPlugins.onAssembly(new FlowableFlattenIterable<T, U>(this, mapper, prefetch));
    //      }

    //public final<R> Flowable<R> concatMapMaybe(Function<? super T, ? extends MaybeSource<? extends R>> mapper) 
    //{
    //          return concatMapMaybe(mapper, 2);
    //      }

    //public final<R> Flowable<R> concatMapMaybe(Function<? super T, ? extends MaybeSource<? extends R>> mapper, int prefetch) 
    //{
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(prefetch, "prefetch");
    //          return RxJavaPlugins.onAssembly(new FlowableConcatMapMaybe<T, R>(this, mapper, ErrorMode.IMMEDIATE, prefetch));
    //      }

    //public final<R> Flowable<R> concatMapMaybeDelayError(Function<? super T, ? extends MaybeSource<? extends R>> mapper) 
    //{
    //          return concatMapMaybeDelayError(mapper, true, 2);
    //      }

    //public final<R> Flowable<R> concatMapMaybeDelayError(Function<? super T, ? extends MaybeSource<? extends R>> mapper, boolean tillTheEnd) 
    //{
    //          return concatMapMaybeDelayError(mapper, tillTheEnd, 2);
    //      }

    //public final<R> Flowable<R> concatMapMaybeDelayError(Function<? super T, ? extends MaybeSource<? extends R>> mapper, boolean tillTheEnd, int prefetch) 
    //{
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(prefetch, "prefetch");
    //          return RxJavaPlugins.onAssembly(new FlowableConcatMapMaybe<T, R>(this, mapper, tillTheEnd ? ErrorMode.END : ErrorMode.BOUNDARY, prefetch));
    //      }

    //public final<R> Flowable<R> concatMapSingle(Function<? super T, ? extends SingleSource<? extends R>> mapper) 
    //{
    //          return concatMapSingle(mapper, 2);
    //      }

    //public final<R> Flowable<R> concatMapSingle(Function<? super T, ? extends SingleSource<? extends R>> mapper, int prefetch) 
    //{
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(prefetch, "prefetch");
    //          return RxJavaPlugins.onAssembly(new FlowableConcatMapSingle<T, R>(this, mapper, ErrorMode.IMMEDIATE, prefetch));
    //      }

    //public final<R> Flowable<R> concatMapSingleDelayError(Function<? super T, ? extends SingleSource<? extends R>> mapper) 
    //{
    //          return concatMapSingleDelayError(mapper, true, 2);
    //      }

    //public final<R> Flowable<R> concatMapSingleDelayError(Function<? super T, ? extends SingleSource<? extends R>> mapper, boolean tillTheEnd) 
    //{
    //          return concatMapSingleDelayError(mapper, tillTheEnd, 2);
    //      }

    //public final<R> Flowable<R> concatMapSingleDelayError(Function<? super T, ? extends SingleSource<? extends R>> mapper, boolean tillTheEnd, int prefetch) 
    //{
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(prefetch, "prefetch");
    //          return RxJavaPlugins.onAssembly(new FlowableConcatMapSingle<T, R>(this, mapper, tillTheEnd ? ErrorMode.END : ErrorMode.BOUNDARY, prefetch));
    //      }

    //public final Flowable<T> concatWith(Publisher<? extends T> other) {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return concat(this, other);
    //      }

    //public final Flowable<T> concatWith(@NonNull SingleSource<? extends T> other)
    //      {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return RxJavaPlugins.onAssembly(new FlowableConcatWithSingle<T>(this, other));
    //      }

    //public final Flowable<T> concatWith(@NonNull MaybeSource<? extends T> other)
    //      {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return RxJavaPlugins.onAssembly(new FlowableConcatWithMaybe<T>(this, other));
    //      }

    //public final Flowable<T> concatWith(@NonNull CompletableSource other)
    //      {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return RxJavaPlugins.onAssembly(new FlowableConcatWithCompletable<T>(this, other));
    //      }

    //public final Single<Boolean> contains(final Object item)
    //      {
    //          ObjectHelper.requireNonNull(item, "item is null");
    //          return any(Functions.equalsWith(item));
    //      }

    //public final Single<Long> count() 
    //{
    //          return RxJavaPlugins.onAssembly(new FlowableCountSingle<T>(this));
    //      }

    //public final<U> Flowable<T> debounce(Function<? super T, ? extends Publisher<U>> debounceIndicator) 
    //{
    //          ObjectHelper.requireNonNull(debounceIndicator, "debounceIndicator is null");
    //          return RxJavaPlugins.onAssembly(new FlowableDebounce<T, U>(this, debounceIndicator));
    //      }

    //public final Flowable<T> debounce(long timeout, TimeUnit unit) 
    //{
    //          return debounce(timeout, unit, Schedulers.computation());
    //      }

    //public final Flowable<T> debounce(long timeout, TimeUnit unit, Scheduler scheduler) 
    //{
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return RxJavaPlugins.onAssembly(new FlowableDebounceTimed<T>(this, timeout, unit, scheduler));
    //      }

    //public final Flowable<T> defaultIfEmpty(T defaultItem) 
    //{
    //          ObjectHelper.requireNonNull(defaultItem, "item is null");
    //          return switchIfEmpty(just(defaultItem));
    //      }

    //public final<U> Flowable<T> delay(final Function<? super T, ? extends Publisher<U>> itemDelayIndicator)
    //      {
    //          ObjectHelper.requireNonNull(itemDelayIndicator, "itemDelayIndicator is null");
    //          return flatMap(FlowableInternalHelper.itemDelay(itemDelayIndicator));
    //      }

    //public final Flowable<T> delay(long delay, TimeUnit unit) 
    //{
    //          return delay(delay, unit, Schedulers.computation(), false);
    //      }

    //public final Flowable<T> delay(long delay, TimeUnit unit, boolean delayError) 
    //{
    //          return delay(delay, unit, Schedulers.computation(), delayError);
    //      }

    //public final Flowable<T> delay(long delay, TimeUnit unit, Scheduler scheduler) {
    //          return delay(delay, unit, scheduler, false);
    //      }

    //public final Flowable<T> delay(long delay, TimeUnit unit, Scheduler scheduler, boolean delayError) 
    //{
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");

    //          return RxJavaPlugins.onAssembly(new FlowableDelay<T>(this, Math.max(0L, delay), unit, scheduler, delayError));
    //      }

    //public final<U, V> Flowable<T> delay(Publisher<U> subscriptionIndicator,
    //          Function<? super T, ? extends Publisher<V>> itemDelayIndicator) 
    //{
    //          return delaySubscription(subscriptionIndicator).delay(itemDelayIndicator);
    //      }

    //public final<U> Flowable<T> delaySubscription(Publisher<U> subscriptionIndicator) 
    //{
    //          ObjectHelper.requireNonNull(subscriptionIndicator, "subscriptionIndicator is null");
    //          return RxJavaPlugins.onAssembly(new FlowableDelaySubscriptionOther<T, U>(this, subscriptionIndicator));
    //      }

    //public final Flowable<T> delaySubscription(long delay, TimeUnit unit) 
    //{
    //          return delaySubscription(delay, unit, Schedulers.computation());
    //      }

    //public final Flowable<T> delaySubscription(long delay, TimeUnit unit, Scheduler scheduler) {
    //          return delaySubscription(timer(delay, unit, scheduler));
    //      }

    //public final<T2> Flowable<T2> dematerialize() 
    //{
    //          return RxJavaPlugins.onAssembly(new FlowableDematerialize(this, Functions.identity()));
    //      }

    //public final<R> Flowable<R> dematerialize(Function<? super T, Notification<R>> selector) 
    //{
    //          ObjectHelper.requireNonNull(selector, "selector is null");
    //          return RxJavaPlugins.onAssembly(new FlowableDematerialize<T, R>(this, selector));
    //      }

    //public final Flowable<T> distinct() 
    //{
    //          return distinct((Function)Functions.identity(), Functions.< T > createHashSet());
    //      }

    //public final<K> Flowable<T> distinct(Function<? super T, K> keySelector) {
    //          return distinct(keySelector, Functions.< K > createHashSet());
    //      }

    //public final<K> Flowable<T> distinct(Function<? super T, K> keySelector,
    //		Callable<? extends Collection<? super K>> collectionSupplier) 
    //{
    //          ObjectHelper.requireNonNull(keySelector, "keySelector is null");
    //          ObjectHelper.requireNonNull(collectionSupplier, "collectionSupplier is null");
    //          return RxJavaPlugins.onAssembly(new FlowableDistinct<T, K>(this, keySelector, collectionSupplier));
    //      }

    //public final Flowable<T> distinctUntilChanged() 
    //{
    //          return distinctUntilChanged(Functions.identity());
    //      }

    //public final<K> Flowable<T> distinctUntilChanged(Function<? super T, K> keySelector) 
    //{
    //          ObjectHelper.requireNonNull(keySelector, "keySelector is null");
    //          return RxJavaPlugins.onAssembly(new FlowableDistinctUntilChanged<T, K>(this, keySelector, ObjectHelper.equalsPredicate()));
    //      }

    //public final Flowable<T> distinctUntilChanged(BiPredicate<? super T, ? super T> comparer) 
    //{
    //          ObjectHelper.requireNonNull(comparer, "comparer is null");
    //          return RxJavaPlugins.onAssembly(new FlowableDistinctUntilChanged<T, T>(this, Functions.< T > identity(), comparer));
    //      }

    //public final Flowable<T> doFinally(Action onFinally) 
    //{
    //          ObjectHelper.requireNonNull(onFinally, "onFinally is null");
    //          return RxJavaPlugins.onAssembly(new FlowableDoFinally<T>(this, onFinally));
    //      }

    //public final Flowable<T> doAfterNext(Consumer<? super T> onAfterNext) 
    //{
    //          ObjectHelper.requireNonNull(onAfterNext, "onAfterNext is null");
    //          return RxJavaPlugins.onAssembly(new FlowableDoAfterNext<T>(this, onAfterNext));
    //      }

    //public final Flowable<T> doAfterTerminate(Action onAfterTerminate) 
    //{
    //          return doOnEach(Functions.emptyConsumer(), Functions.emptyConsumer(),
    //                  Functions.EMPTY_ACTION, onAfterTerminate);
    //      }

    //public final Flowable<T> doOnCancel(Action onCancel) 
    //{
    //          return doOnLifecycle(Functions.emptyConsumer(), Functions.EMPTY_LONG_CONSUMER, onCancel);
    //      }

    //public final Flowable<T> doOnComplete(Action onComplete) 
    //{
    //          return doOnEach(Functions.emptyConsumer(), Functions.emptyConsumer(),
    //                  onComplete, Functions.EMPTY_ACTION);
    //      }

    //private Flowable<T> doOnEach(Consumer<? super T> onNext, Consumer<? super Throwable> onError,
    //		Action onComplete, Action onAfterTerminate)
    //      {
    //          ObjectHelper.requireNonNull(onNext, "onNext is null");
    //          ObjectHelper.requireNonNull(onError, "onError is null");
    //          ObjectHelper.requireNonNull(onComplete, "onComplete is null");
    //          ObjectHelper.requireNonNull(onAfterTerminate, "onAfterTerminate is null");
    //          return RxJavaPlugins.onAssembly(new FlowableDoOnEach<T>(this, onNext, onError, onComplete, onAfterTerminate));
    //      }

    //public final Flowable<T> doOnEach(final Consumer<? super Notification<T>> onNotification)
    //      {
    //          ObjectHelper.requireNonNull(onNotification, "consumer is null");
    //          return doOnEach(
    //                  Functions.notificationOnNext(onNotification),
    //                  Functions.notificationOnError(onNotification),
    //                  Functions.notificationOnComplete(onNotification),
    //                  Functions.EMPTY_ACTION
    //              );
    //      }

    //public final Flowable<T> doOnEach(final Subscriber<? super T> subscriber)
    //      {
    //          ObjectHelper.requireNonNull(subscriber, "subscriber is null");
    //          return doOnEach(
    //                  FlowableInternalHelper.subscriberOnNext(subscriber),
    //                  FlowableInternalHelper.subscriberOnError(subscriber),
    //                  FlowableInternalHelper.subscriberOnComplete(subscriber),
    //                  Functions.EMPTY_ACTION);
    //      }

    //public final Flowable<T> doOnError(Consumer<? super Throwable> onError) 
    //{
    //          return doOnEach(Functions.emptyConsumer(), onError,
    //                  Functions.EMPTY_ACTION, Functions.EMPTY_ACTION);
    //      }

    //public final Flowable<T> doOnLifecycle(final Consumer<? super Subscription> onSubscribe,
    //          final LongConsumer onRequest, final Action onCancel)
    //      {
    //          ObjectHelper.requireNonNull(onSubscribe, "onSubscribe is null");
    //          ObjectHelper.requireNonNull(onRequest, "onRequest is null");
    //          ObjectHelper.requireNonNull(onCancel, "onCancel is null");
    //          return RxJavaPlugins.onAssembly(new FlowableDoOnLifecycle<T>(this, onSubscribe, onRequest, onCancel));
    //      }

    //public final Flowable<T> doOnNext(Consumer<? super T> onNext) 
    //{
    //          return doOnEach(onNext, Functions.emptyConsumer(),
    //                  Functions.EMPTY_ACTION, Functions.EMPTY_ACTION);
    //      }

    //public final Flowable<T> doOnRequest(LongConsumer onRequest) 
    //{
    //          return doOnLifecycle(Functions.emptyConsumer(), onRequest, Functions.EMPTY_ACTION);
    //      }

    //public final Flowable<T> doOnSubscribe(Consumer<? super Subscription> onSubscribe) 
    //{
    //          return doOnLifecycle(onSubscribe, Functions.EMPTY_LONG_CONSUMER, Functions.EMPTY_ACTION);
    //      }

    //public final Flowable<T> doOnTerminate(final Action onTerminate)
    //      {
    //          return doOnEach(Functions.emptyConsumer(), Functions.actionConsumer(onTerminate),
    //                  onTerminate, Functions.EMPTY_ACTION);
    //      }

    //public final Maybe<T> elementAt(long index) 
    //{
    //          if (index < 0)
    //          {
    //              throw new IndexOutOfBoundsException("index >= 0 required but it was " + index);
    //          }
    //          return RxJavaPlugins.onAssembly(new FlowableElementAtMaybe<T>(this, index));
    //      }

    //public final Single<T> elementAt(long index, T defaultItem) 
    //{
    //          if (index < 0)
    //          {
    //              throw new IndexOutOfBoundsException("index >= 0 required but it was " + index);
    //          }
    //          ObjectHelper.requireNonNull(defaultItem, "defaultItem is null");
    //          return RxJavaPlugins.onAssembly(new FlowableElementAtSingle<T>(this, index, defaultItem));
    //      }

    //public final Single<T> elementAtOrError(long index)
    //{
    //          if (index < 0)
    //          {
    //              throw new IndexOutOfBoundsException("index >= 0 required but it was " + index);
    //          }
    //          return RxJavaPlugins.onAssembly(new FlowableElementAtSingle<T>(this, index, null));
    //      }

    //public final Flowable<T> filter(Predicate<? super T> predicate) 
    //{
    //          ObjectHelper.requireNonNull(predicate, "predicate is null");
    //          return RxJavaPlugins.onAssembly(new FlowableFilter<T>(this, predicate));
    //      }

    //public final Maybe<T> firstElement() 
    //{
    //          return elementAt(0);
    //      }

    //public final Single<T> first(T defaultItem) 
    //{
    //          return elementAt(0, defaultItem);
    //      }

    //public final Single<T> firstOrError() 
    //{
    //          return elementAtOrError(0);
    //      }

    //public final<R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends R>> mapper) 
    //{
    //          return flatMap(mapper, false, bufferSize(), bufferSize());
    //      }

    //public final<R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends R>> mapper, boolean delayErrors) 
    //{
    //          return flatMap(mapper, delayErrors, bufferSize(), bufferSize());
    //      }

    //public final<R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends R>> mapper, int maxConcurrency) 
    //{
    //          return flatMap(mapper, false, maxConcurrency, bufferSize());
    //      }

    //public final<R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends R>> mapper, boolean delayErrors, int maxConcurrency) 
    //{
    //          return flatMap(mapper, delayErrors, maxConcurrency, bufferSize());
    //      }

    //public final<R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends R>> mapper,
    //		boolean delayErrors, int maxConcurrency, int bufferSize) 
    //{
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(maxConcurrency, "maxConcurrency");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          if (this instanceof ScalarCallable) 
    //	{
    //			@SuppressWarnings("unchecked")
    //				T v = ((ScalarCallable<T>)this).call();
    //			if (v == null)
    //			{
    //				return empty();
    //			}
    //			return FlowableScalarXMap.scalarXMap(v, mapper);
    //		}
    //		return RxJavaPlugins.onAssembly(new FlowableFlatMap<T, R>(this, mapper, delayErrors, maxConcurrency, bufferSize));
    //      }

    //public final<R> Flowable<R> flatMap(
    //		Function<? super T, ? extends Publisher<? extends R>> onNextMapper,
    //		Function<? super Throwable, ? extends Publisher<? extends R>> onErrorMapper,
    //		Callable<? extends Publisher<? extends R>> onCompleteSupplier) 
    //{
    //          ObjectHelper.requireNonNull(onNextMapper, "onNextMapper is null");
    //          ObjectHelper.requireNonNull(onErrorMapper, "onErrorMapper is null");
    //          ObjectHelper.requireNonNull(onCompleteSupplier, "onCompleteSupplier is null");
    //          return merge(new FlowableMapNotification<T, Publisher<? extends R>>(this, onNextMapper, onErrorMapper, onCompleteSupplier));
    //      }

    //public final<R> Flowable<R> flatMap(
    //		Function<? super T, ? extends Publisher<? extends R>> onNextMapper,
    //		Function<Throwable, ? extends Publisher<? extends R>> onErrorMapper,
    //		Callable<? extends Publisher<? extends R>> onCompleteSupplier,
    //		int maxConcurrency) 
    //{
    //	ObjectHelper.requireNonNull(onNextMapper, "onNextMapper is null");
    //	ObjectHelper.requireNonNull(onErrorMapper, "onErrorMapper is null");
    //	ObjectHelper.requireNonNull(onCompleteSupplier, "onCompleteSupplier is null");
    //	return merge(new FlowableMapNotification<T, Publisher<? extends R>>(
    //			this, onNextMapper, onErrorMapper, onCompleteSupplier), maxConcurrency);
    //}

    //public final<U, R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends U>> mapper,
    //		BiFunction<? super T, ? super U, ? extends R> combiner) 
    //{
    //          return flatMap(mapper, combiner, false, bufferSize(), bufferSize());
    //      }

    //public final<U, R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends U>> mapper,
    //          BiFunction<? super T, ? super U, ? extends R> combiner, boolean delayErrors) 
    //{
    //          return flatMap(mapper, combiner, delayErrors, bufferSize(), bufferSize());
    //      }

    //public final<U, R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends U>> mapper,
    //		BiFunction<? super T, ? super U, ? extends R> combiner, boolean delayErrors, int maxConcurrency) 
    //{
    //          return flatMap(mapper, combiner, delayErrors, maxConcurrency, bufferSize());
    //      }

    //public final<U, R> Flowable<R> flatMap(final Function<? super T, ? extends Publisher<? extends U>> mapper,
    //		final BiFunction<? super T, ? super U, ? extends R> combiner, boolean delayErrors, int maxConcurrency, int bufferSize)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.requireNonNull(combiner, "combiner is null");
    //          ObjectHelper.verifyPositive(maxConcurrency, "maxConcurrency");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          return flatMap(FlowableInternalHelper.flatMapWithCombiner(mapper, combiner), delayErrors, maxConcurrency, bufferSize);
    //      }

    //public final<U, R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends U>> mapper,
    //          BiFunction<? super T, ? super U, ? extends R> combiner, int maxConcurrency) 
    //{
    //          return flatMap(mapper, combiner, false, maxConcurrency, bufferSize());
    //      }

    //public final Completable flatMapCompletable(Function<? super T, ? extends CompletableSource> mapper)
    //      {
    //          return flatMapCompletable(mapper, false, Integer.MAX_VALUE);
    //      }

    //public final Completable flatMapCompletable(Function<? super T, ? extends CompletableSource> mapper, boolean delayErrors, int maxConcurrency)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(maxConcurrency, "maxConcurrency");
    //          return RxJavaPlugins.onAssembly(new FlowableFlatMapCompletableCompletable<T>(this, mapper, delayErrors, maxConcurrency));
    //      }

    //      public final<U> Flowable<U> flatMapIterable(final Function<? super T, ? extends Iterable<? extends U>> mapper)
    //      {
    //          return flatMapIterable(mapper, bufferSize());
    //      }

    //      public final<U> Flowable<U> flatMapIterable(final Function<? super T, ? extends Iterable<? extends U>> mapper, int bufferSize)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          return RxJavaPlugins.onAssembly(new FlowableFlattenIterable<T, U>(this, mapper, bufferSize));
    //      }

    //      public final<U, V> Flowable<V> flatMapIterable(final Function<? super T, ? extends Iterable<? extends U>> mapper,
    //          final BiFunction<? super T, ? super U, ? extends V> resultSelector)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.requireNonNull(resultSelector, "resultSelector is null");
    //          return flatMap(FlowableInternalHelper.flatMapIntoIterable(mapper), resultSelector, false, bufferSize(), bufferSize());
    //      }

    //      public final<U, V> Flowable<V> flatMapIterable(final Function<? super T, ? extends Iterable<? extends U>> mapper,
    //          final BiFunction<? super T, ? super U, ? extends V> resultSelector, int prefetch)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.requireNonNull(resultSelector, "resultSelector is null");
    //          return flatMap(FlowableInternalHelper.flatMapIntoIterable(mapper), resultSelector, false, bufferSize(), prefetch);
    //      }

    //      public final<R> Flowable<R> flatMapMaybe(Function<? super T, ? extends MaybeSource<? extends R>> mapper) {
    //          return flatMapMaybe(mapper, false, Integer.MAX_VALUE);
    //      }

    //      public final<R> Flowable<R> flatMapMaybe(Function<? super T, ? extends MaybeSource<? extends R>> mapper, boolean delayErrors, int maxConcurrency) {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(maxConcurrency, "maxConcurrency");
    //          return RxJavaPlugins.onAssembly(new FlowableFlatMapMaybe<T, R>(this, mapper, delayErrors, maxConcurrency));
    //      }

    //      public final<R> Flowable<R> flatMapSingle(Function<? super T, ? extends SingleSource<? extends R>> mapper) {
    //          return flatMapSingle(mapper, false, Integer.MAX_VALUE);
    //      }

    //      public final<R> Flowable<R> flatMapSingle(Function<? super T, ? extends SingleSource<? extends R>> mapper, boolean delayErrors, int maxConcurrency) {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(maxConcurrency, "maxConcurrency");
    //          return RxJavaPlugins.onAssembly(new FlowableFlatMapSingle<T, R>(this, mapper, delayErrors, maxConcurrency));
    //      }

    //      public final Disposable forEach(Consumer<? super T> onNext)
    //      {
    //          return subscribe(onNext);
    //      }

    //      public final Disposable forEachWhile(Predicate<? super T> onNext)
    //      {
    //          return forEachWhile(onNext, Functions.ON_ERROR_MISSING, Functions.EMPTY_ACTION);
    //      }

    //      public final Disposable forEachWhile(Predicate<? super T> onNext, Consumer<? super Throwable> onError)
    //      {
    //          return forEachWhile(onNext, onError, Functions.EMPTY_ACTION);
    //      }

    //      public final Disposable forEachWhile(final Predicate<? super T> onNext, final Consumer<? super Throwable> onError,
    //          final Action onComplete)
    //      {
    //          ObjectHelper.requireNonNull(onNext, "onNext is null");
    //          ObjectHelper.requireNonNull(onError, "onError is null");
    //          ObjectHelper.requireNonNull(onComplete, "onComplete is null");

    //          ForEachWhileSubscriber<T> s = new ForEachWhileSubscriber<T>(onNext, onError, onComplete);
    //          subscribe(s);
    //          return s;
    //      }

    //      public final<K> Flowable<GroupedFlowable<K, T>> groupBy(Function<? super T, ? extends K> keySelector) {
    //          return groupBy(keySelector, Functions.< T > identity(), false, bufferSize());
    //      }

    //      public final<K> Flowable<GroupedFlowable<K, T>> groupBy(Function<? super T, ? extends K> keySelector, boolean delayError) {
    //          return groupBy(keySelector, Functions.< T > identity(), delayError, bufferSize());
    //      }

    //      public final<K, V> Flowable<GroupedFlowable<K, V>> groupBy(Function<? super T, ? extends K> keySelector,
    //          Function<? super T, ? extends V> valueSelector) {
    //          return groupBy(keySelector, valueSelector, false, bufferSize());
    //      }

    //      public final<K, V> Flowable<GroupedFlowable<K, V>> groupBy(Function<? super T, ? extends K> keySelector,
    //          Function<? super T, ? extends V> valueSelector, boolean delayError) {
    //          return groupBy(keySelector, valueSelector, delayError, bufferSize());
    //      }

    //      public final<K, V> Flowable<GroupedFlowable<K, V>> groupBy(Function<? super T, ? extends K> keySelector,
    //          Function<? super T, ? extends V> valueSelector,
    //          boolean delayError, int bufferSize) 
    //{
    //          ObjectHelper.requireNonNull(keySelector, "keySelector is null");
    //          ObjectHelper.requireNonNull(valueSelector, "valueSelector is null");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");

    //          return RxJavaPlugins.onAssembly(new FlowableGroupBy<T, K, V>(this, keySelector, valueSelector, bufferSize, delayError, null));
    //      }

    //      public final<K, V> Flowable<GroupedFlowable<K, V>> groupBy(Function<? super T, ? extends K> keySelector,
    //          Function<? super T, ? extends V> valueSelector,
    //          boolean delayError, int bufferSize,
    //          Function<? super Consumer<Object>, ? extends Map<K, Object>> evictingMapFactory) {
    //          ObjectHelper.requireNonNull(keySelector, "keySelector is null");
    //          ObjectHelper.requireNonNull(valueSelector, "valueSelector is null");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          ObjectHelper.requireNonNull(evictingMapFactory, "evictingMapFactory is null");

    //          return RxJavaPlugins.onAssembly(new FlowableGroupBy<T, K, V>(this, keySelector, valueSelector, bufferSize, delayError, evictingMapFactory));
    //      }

    //      public final<TRight, TLeftEnd, TRightEnd, R> Flowable<R> groupJoin(
    //          Publisher<? extends TRight> other,
    //          Function<? super T, ? extends Publisher<TLeftEnd>> leftEnd,
    //          Function<? super TRight, ? extends Publisher<TRightEnd>> rightEnd,
    //          BiFunction<? super T, ? super Flowable<TRight>, ? extends R> resultSelector) {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          ObjectHelper.requireNonNull(leftEnd, "leftEnd is null");
    //          ObjectHelper.requireNonNull(rightEnd, "rightEnd is null");
    //          ObjectHelper.requireNonNull(resultSelector, "resultSelector is null");
    //          return RxJavaPlugins.onAssembly(new FlowableGroupJoin<T, TRight, TLeftEnd, TRightEnd, R>(
    //                  this, other, leftEnd, rightEnd, resultSelector));
    //      }

    //      public final Flowable<T> hide() {
    //          return RxJavaPlugins.onAssembly(new FlowableHide<T>(this));
    //      }

    //      public final Completable ignoreElements()
    //      {
    //          return RxJavaPlugins.onAssembly(new FlowableIgnoreElementsCompletable<T>(this));
    //      }

    //      public final Single<Boolean> isEmpty() {
    //          return all(Functions.alwaysFalse());
    //      }

    //      public final<TRight, TLeftEnd, TRightEnd, R> Flowable<R> join(
    //          Publisher<? extends TRight> other,
    //          Function<? super T, ? extends Publisher<TLeftEnd>> leftEnd,
    //          Function<? super TRight, ? extends Publisher<TRightEnd>> rightEnd,
    //          BiFunction<? super T, ? super TRight, ? extends R> resultSelector) 
    //{
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          ObjectHelper.requireNonNull(leftEnd, "leftEnd is null");
    //          ObjectHelper.requireNonNull(rightEnd, "rightEnd is null");
    //          ObjectHelper.requireNonNull(resultSelector, "resultSelector is null");
    //          return RxJavaPlugins.onAssembly(new FlowableJoin<T, TRight, TLeftEnd, TRightEnd, R>(
    //                  this, other, leftEnd, rightEnd, resultSelector));
    //      }

    //      public final Maybe<T> lastElement() {
    //          return RxJavaPlugins.onAssembly(new FlowableLastMaybe<T>(this));
    //      }

    //      public final Single<T> last(T defaultItem) {
    //          ObjectHelper.requireNonNull(defaultItem, "defaultItem");
    //          return RxJavaPlugins.onAssembly(new FlowableLastSingle<T>(this, defaultItem));
    //      }

    //      public final Single<T> lastOrError() {
    //          return RxJavaPlugins.onAssembly(new FlowableLastSingle<T>(this, null));
    //      }

    //      public final<R> Flowable<R> lift(FlowableOperator<? extends R, ? super T> lifter) {
    //          ObjectHelper.requireNonNull(lifter, "lifter is null");
    //          return RxJavaPlugins.onAssembly(new FlowableLift<R, T>(this, lifter));
    //      }

    //      public final Flowable<T> limit(long count) 
    //{
    //          if (count < 0)
    //          {
    //              throw new IllegalArgumentException("count >= 0 required but it was " + count);
    //          }
    //          return RxJavaPlugins.onAssembly(new FlowableLimit<T>(this, count));
    //      }

    //      public final<R> Flowable<R> map(Function<? super T, ? extends R> mapper) {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          return RxJavaPlugins.onAssembly(new FlowableMap<T, R>(this, mapper));
    //      }

    //      public final Flowable<Notification<T>> materialize() {
    //          return RxJavaPlugins.onAssembly(new FlowableMaterialize<T>(this));
    //      }

    //      public final Flowable<T> mergeWith(Publisher<? extends T> other) {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return merge(this, other);
    //      }

    //      public final Flowable<T> mergeWith(@NonNull SingleSource<? extends T> other)
    //      {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return RxJavaPlugins.onAssembly(new FlowableMergeWithSingle<T>(this, other));
    //      }

    //      public final Flowable<T> mergeWith(@NonNull MaybeSource<? extends T> other)
    //      {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return RxJavaPlugins.onAssembly(new FlowableMergeWithMaybe<T>(this, other));
    //      }

    //      public final Flowable<T> mergeWith(@NonNull CompletableSource other)
    //      {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return RxJavaPlugins.onAssembly(new FlowableMergeWithCompletable<T>(this, other));
    //      }

    //      public final Flowable<T> observeOn(Scheduler scheduler) {
    //          return observeOn(scheduler, false, bufferSize());
    //      }

    //      public final Flowable<T> observeOn(Scheduler scheduler, boolean delayError) {
    //          return observeOn(scheduler, delayError, bufferSize());
    //      }

    //      public final Flowable<T> observeOn(Scheduler scheduler, boolean delayError, int bufferSize) {
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          return RxJavaPlugins.onAssembly(new FlowableObserveOn<T>(this, scheduler, delayError, bufferSize));
    //      }

    //      public final<U> Flowable<U> ofType(final Class<U> clazz)
    //      {
    //          ObjectHelper.requireNonNull(clazz, "clazz is null");
    //          return filter(Functions.isInstanceOf(clazz)).cast(clazz);
    //      }

    //      public final Flowable<T> onBackpressureBuffer() {
    //          return onBackpressureBuffer(bufferSize(), false, true);
    //      }

    //      public final Flowable<T> onBackpressureBuffer(boolean delayError) {
    //          return onBackpressureBuffer(bufferSize(), delayError, true);
    //      }

    //      public final Flowable<T> onBackpressureBuffer(int capacity) {
    //          return onBackpressureBuffer(capacity, false, false);
    //      }

    //      public final Flowable<T> onBackpressureBuffer(int capacity, boolean delayError) {
    //          return onBackpressureBuffer(capacity, delayError, false);
    //      }

    //      public final Flowable<T> onBackpressureBuffer(int capacity, boolean delayError, boolean unbounded) {
    //          ObjectHelper.verifyPositive(capacity, "bufferSize");
    //          return RxJavaPlugins.onAssembly(new FlowableOnBackpressureBuffer<T>(this, capacity, unbounded, delayError, Functions.EMPTY_ACTION));
    //      }

    //      public final Flowable<T> onBackpressureBuffer(int capacity, boolean delayError, boolean unbounded,
    //          Action onOverflow) {
    //          ObjectHelper.requireNonNull(onOverflow, "onOverflow is null");
    //          ObjectHelper.verifyPositive(capacity, "capacity");
    //          return RxJavaPlugins.onAssembly(new FlowableOnBackpressureBuffer<T>(this, capacity, unbounded, delayError, onOverflow));
    //      }

    //      public final Flowable<T> onBackpressureBuffer(int capacity, Action onOverflow) {
    //          return onBackpressureBuffer(capacity, false, false, onOverflow);
    //      }

    //      public final Flowable<T> onBackpressureBuffer(long capacity, Action onOverflow, BackpressureOverflowStrategy overflowStrategy) {
    //          ObjectHelper.requireNonNull(overflowStrategy, "strategy is null");
    //          ObjectHelper.verifyPositive(capacity, "capacity");
    //          return RxJavaPlugins.onAssembly(new FlowableOnBackpressureBufferStrategy<T>(this, capacity, onOverflow, overflowStrategy));
    //      }

    //      public final Flowable<T> onBackpressureDrop() 
    //{
    //          return RxJavaPlugins.onAssembly(new FlowableOnBackpressureDrop<T>(this));
    //      }

    //      public final Flowable<T> onBackpressureDrop(Consumer<? super T> onDrop) 
    //{
    //          ObjectHelper.requireNonNull(onDrop, "onDrop is null");
    //          return RxJavaPlugins.onAssembly(new FlowableOnBackpressureDrop<T>(this, onDrop));
    //      }

    //      public final Flowable<T> onBackpressureLatest() 
    //{
    //          return RxJavaPlugins.onAssembly(new FlowableOnBackpressureLatest<T>(this));
    //      }

    //      public final Flowable<T> onErrorResumeNext(Function<? super Throwable, ? extends Publisher<? extends T>> resumeFunction) 
    //{
    //          ObjectHelper.requireNonNull(resumeFunction, "resumeFunction is null");
    //          return RxJavaPlugins.onAssembly(new FlowableOnErrorNext<T>(this, resumeFunction, false));
    //      }

    //      public final Flowable<T> onErrorResumeNext(final Publisher<? extends T> next)
    //      {
    //          ObjectHelper.requireNonNull(next, "next is null");
    //          return onErrorResumeNext(Functions.justFunction(next));
    //      }

    //      public final Flowable<T> onErrorReturn(Function<? super Throwable, ? extends T> valueSupplier) 
    //{
    //          ObjectHelper.requireNonNull(valueSupplier, "valueSupplier is null");
    //          return RxJavaPlugins.onAssembly(new FlowableOnErrorReturn<T>(this, valueSupplier));
    //      }

    //      public final Flowable<T> onErrorReturnItem(final T item)
    //      {
    //          ObjectHelper.requireNonNull(item, "item is null");
    //          return onErrorReturn(Functions.justFunction(item));
    //      }

    //      public final Flowable<T> onExceptionResumeNext(final Publisher<? extends T> next)
    //      {
    //          ObjectHelper.requireNonNull(next, "next is null");
    //          return RxJavaPlugins.onAssembly(new FlowableOnErrorNext<T>(this, Functions.justFunction(next), true));
    //      }

    //      public final Flowable<T> onTerminateDetach()
    //{
    //          return RxJavaPlugins.onAssembly(new FlowableDetach<T>(this));
    //      }

    //      public final ParallelFlowable<T> parallel() 
    //{
    //          return ParallelFlowable.from(this);
    //      }

    //      public final ParallelFlowable<T> parallel(int parallelism) 
    //{
    //          ObjectHelper.verifyPositive(parallelism, "parallelism");
    //          return ParallelFlowable.from(this, parallelism);
    //      }

    //      public final ParallelFlowable<T> parallel(int parallelism, int prefetch) {
    //          ObjectHelper.verifyPositive(parallelism, "parallelism");
    //          ObjectHelper.verifyPositive(prefetch, "prefetch");
    //          return ParallelFlowable.from(this, parallelism, prefetch);
    //      }

    //      public final ConnectableFlowable<T> publish() {
    //          return publish(bufferSize());
    //      }

    //      public final<R> Flowable<R> publish(Function<? super Flowable<T>, ? extends Publisher<R>> selector) {
    //          return publish(selector, bufferSize());
    //      }

    //      public final<R> Flowable<R> publish(Function<? super Flowable<T>, ? extends Publisher<? extends R>> selector, int prefetch) {
    //          ObjectHelper.requireNonNull(selector, "selector is null");
    //          ObjectHelper.verifyPositive(prefetch, "prefetch");
    //          return RxJavaPlugins.onAssembly(new FlowablePublishMulticast<T, R>(this, selector, prefetch, false));
    //      }

    //      public final ConnectableFlowable<T> publish(int bufferSize) {
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          return FlowablePublish.create(this, bufferSize);
    //      }

    //      public final Flowable<T> rebatchRequests(int n) {
    //          return observeOn(ImmediateThinScheduler.INSTANCE, true, n);
    //      }

    //      public final Maybe<T> reduce(BiFunction<T, T, T> reducer) {
    //          ObjectHelper.requireNonNull(reducer, "reducer is null");
    //          return RxJavaPlugins.onAssembly(new FlowableReduceMaybe<T>(this, reducer));
    //      }

    //      public final<R> Single<R> reduce(R seed, BiFunction<R, ? super T, R> reducer) {
    //          ObjectHelper.requireNonNull(seed, "seed is null");
    //          ObjectHelper.requireNonNull(reducer, "reducer is null");
    //          return RxJavaPlugins.onAssembly(new FlowableReduceSeedSingle<T, R>(this, seed, reducer));
    //      }

    //      public final<R> Single<R> reduceWith(Callable<R> seedSupplier, BiFunction<R, ? super T, R> reducer) {
    //          ObjectHelper.requireNonNull(seedSupplier, "seedSupplier is null");
    //          ObjectHelper.requireNonNull(reducer, "reducer is null");
    //          return RxJavaPlugins.onAssembly(new FlowableReduceWithSingle<T, R>(this, seedSupplier, reducer));
    //      }

    //      public final Flowable<T> repeat() {
    //          return repeat(Long.MAX_VALUE);
    //      }

    //      public final Flowable<T> repeat(long times) 
    //{
    //          if (times < 0)
    //          {
    //              throw new IllegalArgumentException("times >= 0 required but it was " + times);
    //          }
    //          if (times == 0)
    //          {
    //              return empty();
    //          }
    //          return RxJavaPlugins.onAssembly(new FlowableRepeat<T>(this, times));
    //      }

    //      public final Flowable<T> repeatUntil(BooleanSupplier stop) 
    //{
    //          ObjectHelper.requireNonNull(stop, "stop is null");
    //          return RxJavaPlugins.onAssembly(new FlowableRepeatUntil<T>(this, stop));
    //      }

    //      public final Flowable<T> repeatWhen(final Function<? super Flowable<Object>, ? extends Publisher<?>> handler)
    //      {
    //          ObjectHelper.requireNonNull(handler, "handler is null");
    //          return RxJavaPlugins.onAssembly(new FlowableRepeatWhen<T>(this, handler));
    //      }

    //      public final ConnectableFlowable<T> replay() {
    //          return FlowableReplay.createFrom(this);
    //      }

    //      public final<R> Flowable<R> replay(Function<? super Flowable<T>, ? extends Publisher<R>> selector) {
    //          ObjectHelper.requireNonNull(selector, "selector is null");
    //          return FlowableReplay.multicastSelector(FlowableInternalHelper.replayCallable(this), selector);
    //      }

    //      public final<R> Flowable<R> replay(Function<? super Flowable<T>, ? extends Publisher<R>> selector, final int bufferSize)
    //      {
    //          ObjectHelper.requireNonNull(selector, "selector is null");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          return FlowableReplay.multicastSelector(FlowableInternalHelper.replayCallable(this, bufferSize), selector);
    //      }

    //      public final<R> Flowable<R> replay(Function<? super Flowable<T>, ? extends Publisher<R>> selector, int bufferSize, long time, TimeUnit unit) {
    //          return replay(selector, bufferSize, time, unit, Schedulers.computation());
    //      }

    //      public final<R> Flowable<R> replay(Function<? super Flowable<T>, ? extends Publisher<R>> selector, final int bufferSize, final long time, final TimeUnit unit, final Scheduler scheduler)
    //      {
    //          ObjectHelper.requireNonNull(selector, "selector is null");
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return FlowableReplay.multicastSelector(
    //                  FlowableInternalHelper.replayCallable(this, bufferSize, time, unit, scheduler), selector);
    //      }

    //      public final<R> Flowable<R> replay(final Function<? super Flowable<T>, ? extends Publisher<R>> selector, final int bufferSize, final Scheduler scheduler)
    //      {
    //          ObjectHelper.requireNonNull(selector, "selector is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          return FlowableReplay.multicastSelector(FlowableInternalHelper.replayCallable(this, bufferSize),
    //                  FlowableInternalHelper.replayFunction(selector, scheduler)
    //          );
    //      }

    //      public final<R> Flowable<R> replay(Function<? super Flowable<T>, ? extends Publisher<R>> selector, long time, TimeUnit unit) {
    //          return replay(selector, time, unit, Schedulers.computation());
    //      }

    //      public final<R> Flowable<R> replay(Function<? super Flowable<T>, ? extends Publisher<R>> selector, final long time, final TimeUnit unit, final Scheduler scheduler)
    //      {
    //          ObjectHelper.requireNonNull(selector, "selector is null");
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return FlowableReplay.multicastSelector(FlowableInternalHelper.replayCallable(this, time, unit, scheduler), selector);
    //      }

    //      public final<R> Flowable<R> replay(final Function<? super Flowable<T>, ? extends Publisher<R>> selector, final Scheduler scheduler)
    //      {
    //          ObjectHelper.requireNonNull(selector, "selector is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return FlowableReplay.multicastSelector(FlowableInternalHelper.replayCallable(this),
    //                  FlowableInternalHelper.replayFunction(selector, scheduler));
    //      }

    //      public final ConnectableFlowable<T> replay(final int bufferSize)
    //      {
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          return FlowableReplay.create(this, bufferSize);
    //      }

    //      public final ConnectableFlowable<T> replay(int bufferSize, long time, TimeUnit unit) {
    //          return replay(bufferSize, time, unit, Schedulers.computation());
    //      }

    //      public final ConnectableFlowable<T> replay(final int bufferSize, final long time, final TimeUnit unit, final Scheduler scheduler)
    //      {
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          return FlowableReplay.create(this, time, unit, scheduler, bufferSize);
    //      }

    //      public final ConnectableFlowable<T> replay(final int bufferSize, final Scheduler scheduler)
    //      {
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return FlowableReplay.observeOn(replay(bufferSize), scheduler);
    //      }

    //      public final ConnectableFlowable<T> replay(long time, TimeUnit unit) {
    //          return replay(time, unit, Schedulers.computation());
    //      }

    //      public final ConnectableFlowable<T> replay(final long time, final TimeUnit unit, final Scheduler scheduler)
    //      {
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return FlowableReplay.create(this, time, unit, scheduler);
    //      }

    //      public final ConnectableFlowable<T> replay(final Scheduler scheduler)
    //      {
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return FlowableReplay.observeOn(replay(), scheduler);
    //      }

    //      public final Flowable<T> retry() {
    //          return retry(Long.MAX_VALUE, Functions.alwaysTrue());
    //      }

    //      public final Flowable<T> retry(BiPredicate<? super Integer, ? super Throwable> predicate) {
    //          ObjectHelper.requireNonNull(predicate, "predicate is null");

    //          return RxJavaPlugins.onAssembly(new FlowableRetryBiPredicate<T>(this, predicate));
    //      }

    //      public final Flowable<T> retry(long count) {
    //          return retry(count, Functions.alwaysTrue());
    //      }

    //      public final Flowable<T> retry(long times, Predicate<? super Throwable> predicate) 
    //{
    //          if (times < 0)
    //          {
    //              throw new IllegalArgumentException("times >= 0 required but it was " + times);
    //          }
    //          ObjectHelper.requireNonNull(predicate, "predicate is null");

    //          return RxJavaPlugins.onAssembly(new FlowableRetryPredicate<T>(this, times, predicate));
    //      }

    //      public final Flowable<T> retry(Predicate<? super Throwable> predicate) {
    //          return retry(Long.MAX_VALUE, predicate);
    //      }

    //      public final Flowable<T> retryUntil(final BooleanSupplier stop)
    //      {
    //          ObjectHelper.requireNonNull(stop, "stop is null");
    //          return retry(Long.MAX_VALUE, Functions.predicateReverseFor(stop));
    //      }

    //      public final Flowable<T> retryWhen(
    //          final Function<? super Flowable<Throwable>, ? extends Publisher<?>> handler)
    //      {
    //          ObjectHelper.requireNonNull(handler, "handler is null");

    //          return RxJavaPlugins.onAssembly(new FlowableRetryWhen<T>(this, handler));
    //      }

    //      public final void safeSubscribe(Subscriber<? super T> s)
    //      {
    //          ObjectHelper.requireNonNull(s, "s is null");
    //          if (s instanceof SafeSubscriber) {
    //              subscribe((SafeSubscriber <? super T >)s);
    //          } else {
    //              subscribe(new SafeSubscriber<T>(s));
    //          }
    //      }

    //      public final Flowable<T> sample(long period, TimeUnit unit) {
    //          return sample(period, unit, Schedulers.computation());
    //      }

    //      public final Flowable<T> sample(long period, TimeUnit unit, boolean emitLast) {
    //          return sample(period, unit, Schedulers.computation(), emitLast);
    //      }

    //      public final Flowable<T> sample(long period, TimeUnit unit, Scheduler scheduler) {
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSampleTimed<T>(this, period, unit, scheduler, false));
    //      }

    //      public final Flowable<T> sample(long period, TimeUnit unit, Scheduler scheduler, boolean emitLast) {
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSampleTimed<T>(this, period, unit, scheduler, emitLast));
    //      }

    //      public final<U> Flowable<T> sample(Publisher<U> sampler) 
    //{
    //          ObjectHelper.requireNonNull(sampler, "sampler is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSamplePublisher<T>(this, sampler, false));
    //      }

    //      public final<U> Flowable<T> sample(Publisher<U> sampler, boolean emitLast) {
    //          ObjectHelper.requireNonNull(sampler, "sampler is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSamplePublisher<T>(this, sampler, emitLast));
    //      }

    //      public final Flowable<T> scan(BiFunction<T, T, T> accumulator) {
    //          ObjectHelper.requireNonNull(accumulator, "accumulator is null");
    //          return RxJavaPlugins.onAssembly(new FlowableScan<T>(this, accumulator));
    //      }

    //      public final<R> Flowable<R> scan(final R initialValue, BiFunction<R, ? super T, R> accumulator)
    //      {
    //          ObjectHelper.requireNonNull(initialValue, "seed is null");
    //          return scanWith(Functions.justCallable(initialValue), accumulator);
    //      }

    //      public final<R> Flowable<R> scanWith(Callable<R> seedSupplier, BiFunction<R, ? super T, R> accumulator) 
    //{
    //          ObjectHelper.requireNonNull(seedSupplier, "seedSupplier is null");
    //          ObjectHelper.requireNonNull(accumulator, "accumulator is null");
    //          return RxJavaPlugins.onAssembly(new FlowableScanSeed<T, R>(this, seedSupplier, accumulator));
    //      }

    //      public final Flowable<T> serialize() 
    //{
    //          return RxJavaPlugins.onAssembly(new FlowableSerialized<T>(this));
    //      }

    //      public final Flowable<T> share() {
    //          return publish().refCount();
    //      }

    //      public final Maybe<T> singleElement() {
    //          return RxJavaPlugins.onAssembly(new FlowableSingleMaybe<T>(this));
    //      }

    //      public final Single<T> single(T defaultItem) {
    //          ObjectHelper.requireNonNull(defaultItem, "defaultItem is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSingleSingle<T>(this, defaultItem));
    //      }

    //      public final Single<T> singleOrError() {
    //          return RxJavaPlugins.onAssembly(new FlowableSingleSingle<T>(this, null));
    //      }

    //      public final Flowable<T> skip(long count) {
    //          if (count <= 0L)
    //          {
    //              return RxJavaPlugins.onAssembly(this);
    //          }
    //          return RxJavaPlugins.onAssembly(new FlowableSkip<T>(this, count));
    //      }

    //      public final Flowable<T> skip(long time, TimeUnit unit) {
    //          return skipUntil(timer(time, unit));
    //      }

    //      public final Flowable<T> skip(long time, TimeUnit unit, Scheduler scheduler) {
    //          return skipUntil(timer(time, unit, scheduler));
    //      }

    //      public final Flowable<T> skipLast(int count) {
    //          if (count < 0)
    //          {
    //              throw new IndexOutOfBoundsException("count >= 0 required but it was " + count);
    //          }
    //          if (count == 0)
    //          {
    //              return RxJavaPlugins.onAssembly(this);
    //          }
    //          return RxJavaPlugins.onAssembly(new FlowableSkipLast<T>(this, count));
    //      }

    //      public final Flowable<T> skipLast(long time, TimeUnit unit) {
    //          return skipLast(time, unit, Schedulers.computation(), false, bufferSize());
    //      }

    //      public final Flowable<T> skipLast(long time, TimeUnit unit, boolean delayError) {
    //          return skipLast(time, unit, Schedulers.computation(), delayError, bufferSize());
    //      }

    //      public final Flowable<T> skipLast(long time, TimeUnit unit, Scheduler scheduler) {
    //          return skipLast(time, unit, scheduler, false, bufferSize());
    //      }

    //      public final Flowable<T> skipLast(long time, TimeUnit unit, Scheduler scheduler, boolean delayError) {
    //          return skipLast(time, unit, scheduler, delayError, bufferSize());
    //      }

    //      public final Flowable<T> skipLast(long time, TimeUnit unit, Scheduler scheduler, boolean delayError, int bufferSize) {
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          // the internal buffer holds pairs of (timestamp, value) so double the default buffer size
    //          int s = bufferSize << 1;
    //          return RxJavaPlugins.onAssembly(new FlowableSkipLastTimed<T>(this, time, unit, scheduler, s, delayError));
    //      }

    //      public final<U> Flowable<T> skipUntil(Publisher<U> other) {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSkipUntil<T, U>(this, other));
    //      }

    //      public final Flowable<T> skipWhile(Predicate<? super T> predicate) {
    //          ObjectHelper.requireNonNull(predicate, "predicate is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSkipWhile<T>(this, predicate));
    //      }

    //      public final Flowable<T> sorted() {
    //          return toList().toFlowable().map(Functions.listSorter(Functions.< T > naturalComparator())).flatMapIterable(Functions.< List < T >> identity());
    //      }

    //      public final Flowable<T> sorted(Comparator<? super T> sortFunction) {
    //          ObjectHelper.requireNonNull(sortFunction, "sortFunction");
    //          return toList().toFlowable().map(Functions.listSorter(sortFunction)).flatMapIterable(Functions.< List < T >> identity());
    //      }

    //      public final Flowable<T> startWith(Iterable<? extends T> items) {
    //          return concatArray(fromIterable(items), this);
    //      }

    //      public final Flowable<T> startWith(Publisher<? extends T> other) {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return concatArray(other, this);
    //      }

    //      public final Flowable<T> startWith(T value) {
    //          ObjectHelper.requireNonNull(value, "item is null");
    //          return concatArray(just(value), this);
    //      }

    //      public final Flowable<T> startWithArray(T...items) {
    //          Flowable<T> fromArray = fromArray(items);
    //          if (fromArray == empty())
    //          {
    //              return RxJavaPlugins.onAssembly(this);
    //          }
    //          return concatArray(fromArray, this);
    //      }


    //      protected abstract void subscribeActual(Subscriber<? super T> s);

    //      public final<E extends Subscriber<? super T>> E subscribeWith(E subscriber)
    //      {
    //          subscribe(subscriber);
    //          return subscriber;
    //      }

    //      public final Flowable<T> subscribeOn(@NonNull Scheduler scheduler)
    //      {
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return subscribeOn(scheduler, !(this instanceof FlowableCreate));
    //      }

    //      public final Flowable<T> subscribeOn(@NonNull Scheduler scheduler, boolean requestOn)
    //      {
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSubscribeOn<T>(this, scheduler, requestOn));
    //      }

    //      public final Flowable<T> switchIfEmpty(Publisher<? extends T> other) {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSwitchIfEmpty<T>(this, other));
    //      }

    //      public final<R> Flowable<R> switchMap(Function<? super T, ? extends Publisher<? extends R>> mapper) {
    //          return switchMap(mapper, bufferSize());
    //      }

    //      public final<R> Flowable<R> switchMap(Function<? super T, ? extends Publisher<? extends R>> mapper, int bufferSize) {
    //          return switchMap0(mapper, bufferSize, false);
    //      }

    //      public final Completable switchMapCompletable(@NonNull Function<? super T, ? extends CompletableSource> mapper)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSwitchMapCompletable<T>(this, mapper, false));
    //      }

    //      public final Completable switchMapCompletableDelayError(@NonNull Function<? super T, ? extends CompletableSource> mapper)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSwitchMapCompletable<T>(this, mapper, true));
    //      }

    //      public final<R> Flowable<R> switchMapDelayError(Function<? super T, ? extends Publisher<? extends R>> mapper) {
    //          return switchMapDelayError(mapper, bufferSize());
    //      }

    //      public final<R> Flowable<R> switchMapDelayError(Function<? super T, ? extends Publisher<? extends R>> mapper, int bufferSize) {
    //          return switchMap0(mapper, bufferSize, true);
    //      }

    //<R> Flowable<R> switchMap0(Function<? super T, ? extends Publisher<? extends R>> mapper, int bufferSize, boolean delayError)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          if (this instanceof ScalarCallable) {
    //              @SuppressWarnings("unchecked")
    //                  T v = ((ScalarCallable<T>)this).call();
    //              if (v == null)
    //              {
    //                  return empty();
    //              }
    //              return FlowableScalarXMap.scalarXMap(v, mapper);
    //          }
    //          return RxJavaPlugins.onAssembly(new FlowableSwitchMap<T, R>(this, mapper, bufferSize, delayError));
    //      }

    //      public final<R> Flowable<R> switchMapMaybe(@NonNull Function<? super T, ? extends MaybeSource<? extends R>> mapper)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSwitchMapMaybe<T, R>(this, mapper, false));
    //      }

    //      public final<R> Flowable<R> switchMapMaybeDelayError(@NonNull Function<? super T, ? extends MaybeSource<? extends R>> mapper)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSwitchMapMaybe<T, R>(this, mapper, true));
    //      }

    //      public final<R> Flowable<R> switchMapSingle(@NonNull Function<? super T, ? extends SingleSource<? extends R>> mapper)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSwitchMapSingle<T, R>(this, mapper, false));
    //      }

    //      public final<R> Flowable<R> switchMapSingleDelayError(@NonNull Function<? super T, ? extends SingleSource<? extends R>> mapper)
    //      {
    //          ObjectHelper.requireNonNull(mapper, "mapper is null");
    //          return RxJavaPlugins.onAssembly(new FlowableSwitchMapSingle<T, R>(this, mapper, true));
    //      }

    //      public final Flowable<T> take(long count) {
    //          if (count < 0)
    //          {
    //              throw new IllegalArgumentException("count >= 0 required but it was " + count);
    //          }
    //          return RxJavaPlugins.onAssembly(new FlowableTake<T>(this, count));
    //      }

    //      public final Flowable<T> take(long time, TimeUnit unit) {
    //          return takeUntil(timer(time, unit));
    //      }

    //      public final Flowable<T> take(long time, TimeUnit unit, Scheduler scheduler) {
    //          return takeUntil(timer(time, unit, scheduler));
    //      }

    //      public final Flowable<T> takeLast(int count) {
    //          if (count < 0)
    //          {
    //              throw new IndexOutOfBoundsException("count >= 0 required but it was " + count);
    //          }
    //          else
    //          if (count == 0)
    //          {
    //              return RxJavaPlugins.onAssembly(new FlowableIgnoreElements<T>(this));
    //          }
    //          else
    //          if (count == 1)
    //          {
    //              return RxJavaPlugins.onAssembly(new FlowableTakeLastOne<T>(this));
    //          }
    //          return RxJavaPlugins.onAssembly(new FlowableTakeLast<T>(this, count));
    //      }

    //      public final Flowable<T> takeLast(long count, long time, TimeUnit unit) {
    //          return takeLast(count, time, unit, Schedulers.computation(), false, bufferSize());
    //      }

    //      public final Flowable<T> takeLast(long count, long time, TimeUnit unit, Scheduler scheduler) {
    //          return takeLast(count, time, unit, scheduler, false, bufferSize());
    //      }

    //      public final Flowable<T> takeLast(long count, long time, TimeUnit unit, Scheduler scheduler, boolean delayError, int bufferSize) {
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          if (count < 0)
    //          {
    //              throw new IndexOutOfBoundsException("count >= 0 required but it was " + count);
    //          }
    //          return RxJavaPlugins.onAssembly(new FlowableTakeLastTimed<T>(this, count, time, unit, scheduler, bufferSize, delayError));
    //      }

    //      public final Flowable<T> takeLast(long time, TimeUnit unit) {
    //          return takeLast(time, unit, Schedulers.computation(), false, bufferSize());
    //      }

    //      public final Flowable<T> takeLast(long time, TimeUnit unit, boolean delayError) {
    //          return takeLast(time, unit, Schedulers.computation(), delayError, bufferSize());
    //      }

    //      public final Flowable<T> takeLast(long time, TimeUnit unit, Scheduler scheduler) {
    //          return takeLast(time, unit, scheduler, false, bufferSize());
    //      }

    //      public final Flowable<T> takeLast(long time, TimeUnit unit, Scheduler scheduler, boolean delayError) {
    //          return takeLast(time, unit, scheduler, delayError, bufferSize());
    //      }

    //      public final Flowable<T> takeLast(long time, TimeUnit unit, Scheduler scheduler, boolean delayError, int bufferSize) {
    //          return takeLast(Long.MAX_VALUE, time, unit, scheduler, delayError, bufferSize);
    //      }

    //      public final Flowable<T> takeUntil(Predicate<? super T> stopPredicate) {
    //          ObjectHelper.requireNonNull(stopPredicate, "stopPredicate is null");
    //          return RxJavaPlugins.onAssembly(new FlowableTakeUntilPredicate<T>(this, stopPredicate));
    //      }

    //      public final<U> Flowable<T> takeUntil(Publisher<U> other) {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return RxJavaPlugins.onAssembly(new FlowableTakeUntil<T, U>(this, other));
    //      }

    //      public final Flowable<T> takeWhile(Predicate<? super T> predicate) {
    //          ObjectHelper.requireNonNull(predicate, "predicate is null");
    //          return RxJavaPlugins.onAssembly(new FlowableTakeWhile<T>(this, predicate));
    //      }

    //      public final Flowable<T> throttleFirst(long windowDuration, TimeUnit unit) {
    //          return throttleFirst(windowDuration, unit, Schedulers.computation());
    //      }

    //      public final Flowable<T> throttleFirst(long skipDuration, TimeUnit unit, Scheduler scheduler) {
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return RxJavaPlugins.onAssembly(new FlowableThrottleFirstTimed<T>(this, skipDuration, unit, scheduler));
    //      }

    //      public final Flowable<T> throttleLast(long intervalDuration, TimeUnit unit) {
    //          return sample(intervalDuration, unit);
    //      }

    //      public final Flowable<T> throttleLast(long intervalDuration, TimeUnit unit, Scheduler scheduler) {
    //          return sample(intervalDuration, unit, scheduler);
    //      }

    //      public final Flowable<T> throttleLatest(long timeout, TimeUnit unit) {
    //          return throttleLatest(timeout, unit, Schedulers.computation(), false);
    //      }

    //      public final Flowable<T> throttleLatest(long timeout, TimeUnit unit, boolean emitLast) {
    //          return throttleLatest(timeout, unit, Schedulers.computation(), emitLast);
    //      }

    //      public final Flowable<T> throttleLatest(long timeout, TimeUnit unit, Scheduler scheduler) {
    //          return throttleLatest(timeout, unit, scheduler, false);
    //      }

    //      public final Flowable<T> throttleLatest(long timeout, TimeUnit unit, Scheduler scheduler, boolean emitLast) {
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return RxJavaPlugins.onAssembly(new FlowableThrottleLatest<T>(this, timeout, unit, scheduler, emitLast));
    //      }

    //      public final Flowable<T> throttleWithTimeout(long timeout, TimeUnit unit) {
    //          return debounce(timeout, unit);
    //      }

    //      public final Flowable<T> throttleWithTimeout(long timeout, TimeUnit unit, Scheduler scheduler) {
    //          return debounce(timeout, unit, scheduler);
    //      }

    //      public final Flowable<Timed<T>> timeInterval() {
    //          return timeInterval(TimeUnit.MILLISECONDS, Schedulers.computation());
    //      }

    //      public final Flowable<Timed<T>> timeInterval(Scheduler scheduler) {
    //          return timeInterval(TimeUnit.MILLISECONDS, scheduler);
    //      }

    //      public final Flowable<Timed<T>> timeInterval(TimeUnit unit) {
    //          return timeInterval(unit, Schedulers.computation());
    //      }

    //      public final Flowable<Timed<T>> timeInterval(TimeUnit unit, Scheduler scheduler) {
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return RxJavaPlugins.onAssembly(new FlowableTimeInterval<T>(this, unit, scheduler));
    //      }

    //      public final<V> Flowable<T> timeout(Function<? super T, ? extends Publisher<V>> itemTimeoutIndicator) {
    //          return timeout0(null, itemTimeoutIndicator, null);
    //      }

    //      public final<V> Flowable<T> timeout(Function<? super T, ? extends Publisher<V>> itemTimeoutIndicator, Flowable<? extends T> other) {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return timeout0(null, itemTimeoutIndicator, other);
    //      }

    //      public final Flowable<T> timeout(long timeout, TimeUnit timeUnit) {
    //          return timeout0(timeout, timeUnit, null, Schedulers.computation());
    //      }

    //      public final Flowable<T> timeout(long timeout, TimeUnit timeUnit, Publisher<? extends T> other) {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return timeout0(timeout, timeUnit, other, Schedulers.computation());
    //      }

    //      public final Flowable<T> timeout(long timeout, TimeUnit timeUnit, Scheduler scheduler, Publisher<? extends T> other) {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return timeout0(timeout, timeUnit, other, scheduler);
    //      }

    //      public final Flowable<T> timeout(long timeout, TimeUnit timeUnit, Scheduler scheduler) {
    //          return timeout0(timeout, timeUnit, null, scheduler);
    //      }

    //      public final<U, V> Flowable<T> timeout(Publisher<U> firstTimeoutIndicator,
    //          Function<? super T, ? extends Publisher<V>> itemTimeoutIndicator) {
    //          ObjectHelper.requireNonNull(firstTimeoutIndicator, "firstTimeoutIndicator is null");
    //          return timeout0(firstTimeoutIndicator, itemTimeoutIndicator, null);
    //      }

    //      public final<U, V> Flowable<T> timeout(
    //          Publisher<U> firstTimeoutIndicator,
    //          Function<? super T, ? extends Publisher<V>> itemTimeoutIndicator,
    //                  Publisher<? extends T> other) 
    //{
    //          ObjectHelper.requireNonNull(firstTimeoutIndicator, "firstTimeoutSelector is null");
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return timeout0(firstTimeoutIndicator, itemTimeoutIndicator, other);
    //      }

    //      private Flowable<T> timeout0(long timeout, TimeUnit timeUnit, Publisher<? extends T> other,
    //              Scheduler scheduler)
    //      {
    //          ObjectHelper.requireNonNull(timeUnit, "timeUnit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return RxJavaPlugins.onAssembly(new FlowableTimeoutTimed<T>(this, timeout, timeUnit, scheduler, other));
    //      }

    //      private <U, V> Flowable<T> timeout0(
    //              Publisher<U> firstTimeoutIndicator,
    //              Function<? super T, ? extends Publisher<V>> itemTimeoutIndicator,
    //                      Publisher<? extends T> other)
    //      {
    //          ObjectHelper.requireNonNull(itemTimeoutIndicator, "itemTimeoutIndicator is null");
    //          return RxJavaPlugins.onAssembly(new FlowableTimeout<T, U, V>(this, firstTimeoutIndicator, itemTimeoutIndicator, other));
    //      }

    //      public final Flowable<Timed<T>> timestamp() {
    //          return timestamp(TimeUnit.MILLISECONDS, Schedulers.computation());
    //      }

    //      public final Flowable<Timed<T>> timestamp(Scheduler scheduler) {
    //          return timestamp(TimeUnit.MILLISECONDS, scheduler);
    //      }

    //      public final Flowable<Timed<T>> timestamp(TimeUnit unit) {
    //          return timestamp(unit, Schedulers.computation());
    //      }

    //      public final Flowable<Timed<T>> timestamp(final TimeUnit unit, final Scheduler scheduler)
    //      {
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return map(Functions.< T > timestampWith(unit, scheduler));
    //      }

    //      public final<R> R to(Function<? super Flowable<T>, R> converter)
    //      {
    //          try
    //          {
    //              return ObjectHelper.requireNonNull(converter, "converter is null").apply(this);
    //          }
    //          catch (Throwable ex)
    //          {
    //              Exceptions.throwIfFatal(ex);
    //              throw ExceptionHelper.wrapOrThrow(ex);
    //          }
    //      }

    //      public final Single<List<T>> toList() {
    //          return RxJavaPlugins.onAssembly(new FlowableToListSingle<T, List<T>>(this));
    //      }

    //      public final Single<List<T>> toList(final int capacityHint)
    //      {
    //          ObjectHelper.verifyPositive(capacityHint, "capacityHint");
    //          return RxJavaPlugins.onAssembly(new FlowableToListSingle<T, List<T>>(this, Functions.< T > createArrayList(capacityHint)));
    //      }

    //      public final<U extends Collection<? super T>> Single<U> toList(Callable<U> collectionSupplier) {
    //          ObjectHelper.requireNonNull(collectionSupplier, "collectionSupplier is null");
    //          return RxJavaPlugins.onAssembly(new FlowableToListSingle<T, U>(this, collectionSupplier));
    //      }

    //      public final<K> Single<Map<K, T>> toMap(final Function<? super T, ? extends K> keySelector)
    //      {
    //          ObjectHelper.requireNonNull(keySelector, "keySelector is null");
    //          return collect(HashMapSupplier.< K, T > asCallable(), Functions.toMapKeySelector(keySelector));
    //      }

    //      public final<K, V> Single<Map<K, V>> toMap(final Function<? super T, ? extends K> keySelector, final Function<? super T, ? extends V> valueSelector)
    //      {
    //          ObjectHelper.requireNonNull(keySelector, "keySelector is null");
    //          ObjectHelper.requireNonNull(valueSelector, "valueSelector is null");
    //          return collect(HashMapSupplier.< K, V > asCallable(), Functions.toMapKeyValueSelector(keySelector, valueSelector));
    //      }

    //      public final<K, V> Single<Map<K, V>> toMap(final Function<? super T, ? extends K> keySelector,
    //          final Function<? super T, ? extends V> valueSelector,
    //          final Callable<? extends Map<K, V>> mapSupplier)
    //      {
    //          ObjectHelper.requireNonNull(keySelector, "keySelector is null");
    //          ObjectHelper.requireNonNull(valueSelector, "valueSelector is null");
    //          return collect(mapSupplier, Functions.toMapKeyValueSelector(keySelector, valueSelector));
    //      }

    //      public final<K> Single<Map<K, Collection<T>>> toMultimap(Function<? super T, ? extends K> keySelector) 
    //{
    //          Function<T, T> valueSelector = Functions.identity();
    //          Callable<Map<K, Collection<T>>> mapSupplier = HashMapSupplier.asCallable();
    //          Function<K, List<T>> collectionFactory = ArrayListSupplier.asFunction();
    //          return toMultimap(keySelector, valueSelector, mapSupplier, collectionFactory);
    //      }

    //      public final<K, V> Single<Map<K, Collection<V>>> toMultimap(Function<? super T, ? extends K> keySelector, Function<? super T, ? extends V> valueSelector) {
    //          Callable<Map<K, Collection<V>>> mapSupplier = HashMapSupplier.asCallable();
    //          Function<K, List<V>> collectionFactory = ArrayListSupplier.asFunction();
    //          return toMultimap(keySelector, valueSelector, mapSupplier, collectionFactory);
    //      }

    //      public final<K, V> Single<Map<K, Collection<V>>> toMultimap(
    //          final Function<? super T, ? extends K> keySelector,
    //          final Function<? super T, ? extends V> valueSelector,
    //          final Callable<? extends Map<K, Collection<V>>> mapSupplier,
    //          final Function<? super K, ? extends Collection<? super V>> collectionFactory)
    //      {
    //          ObjectHelper.requireNonNull(keySelector, "keySelector is null");
    //          ObjectHelper.requireNonNull(valueSelector, "valueSelector is null");
    //          ObjectHelper.requireNonNull(mapSupplier, "mapSupplier is null");
    //          ObjectHelper.requireNonNull(collectionFactory, "collectionFactory is null");
    //          return collect(mapSupplier, Functions.toMultimapKeyValueSelector(keySelector, valueSelector, collectionFactory));
    //      }

    //      public final<K, V> Single<Map<K, Collection<V>>> toMultimap(
    //          Function<? super T, ? extends K> keySelector,
    //          Function<? super T, ? extends V> valueSelector,
    //          Callable<Map<K, Collection<V>>> mapSupplier
    //          ) {
    //          return toMultimap(keySelector, valueSelector, mapSupplier, ArrayListSupplier.< V, K > asFunction());
    //      }

    //      public final Observable<T> toObservable() {
    //          return RxJavaPlugins.onAssembly(new ObservableFromPublisher<T>(this));
    //      }

    //      public final Single<List<T>> toSortedList() {
    //          return toSortedList(Functions.naturalComparator());
    //      }

    //      public final Single<List<T>> toSortedList(final Comparator<? super T> comparator)
    //      {
    //          ObjectHelper.requireNonNull(comparator, "comparator is null");
    //          return toList().map(Functions.listSorter(comparator));
    //      }

    //      public final Single<List<T>> toSortedList(final Comparator<? super T> comparator, int capacityHint)
    //      {
    //          ObjectHelper.requireNonNull(comparator, "comparator is null");
    //          return toList(capacityHint).map(Functions.listSorter(comparator));
    //      }

    //      public final Single<List<T>> toSortedList(int capacityHint) {
    //          return toSortedList(Functions.naturalComparator(), capacityHint);
    //      }

    //      public final Flowable<T> unsubscribeOn(Scheduler scheduler) {
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          return RxJavaPlugins.onAssembly(new FlowableUnsubscribeOn<T>(this, scheduler));
    //      }

    //      public final Flowable<Flowable<T>> window(long count) {
    //          return window(count, count, bufferSize());
    //      }

    //      public final Flowable<Flowable<T>> window(long count, long skip) {
    //          return window(count, skip, bufferSize());
    //      }

    //      public final Flowable<Flowable<T>> window(long count, long skip, int bufferSize) {
    //          ObjectHelper.verifyPositive(skip, "skip");
    //          ObjectHelper.verifyPositive(count, "count");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          return RxJavaPlugins.onAssembly(new FlowableWindow<T>(this, count, skip, bufferSize));
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, long timeskip, TimeUnit unit) {
    //          return window(timespan, timeskip, unit, Schedulers.computation(), bufferSize());
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, long timeskip, TimeUnit unit, Scheduler scheduler) {
    //          return window(timespan, timeskip, unit, scheduler, bufferSize());
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, long timeskip, TimeUnit unit, Scheduler scheduler, int bufferSize) {
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          ObjectHelper.verifyPositive(timespan, "timespan");
    //          ObjectHelper.verifyPositive(timeskip, "timeskip");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          return RxJavaPlugins.onAssembly(new FlowableWindowTimed<T>(this, timespan, timeskip, unit, scheduler, Long.MAX_VALUE, bufferSize, false));
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, TimeUnit unit) {
    //          return window(timespan, unit, Schedulers.computation(), Long.MAX_VALUE, false);
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, TimeUnit unit,
    //          long count) {
    //          return window(timespan, unit, Schedulers.computation(), count, false);
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, TimeUnit unit,
    //          long count, boolean restart) {
    //          return window(timespan, unit, Schedulers.computation(), count, restart);
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, TimeUnit unit,
    //          Scheduler scheduler) {
    //          return window(timespan, unit, scheduler, Long.MAX_VALUE, false);
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, TimeUnit unit,
    //          Scheduler scheduler, long count) {
    //          return window(timespan, unit, scheduler, count, false);
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, TimeUnit unit,
    //          Scheduler scheduler, long count, boolean restart) {
    //          return window(timespan, unit, scheduler, count, restart, bufferSize());
    //      }

    //      public final Flowable<Flowable<T>> window(
    //          long timespan, TimeUnit unit, Scheduler scheduler,
    //          long count, boolean restart, int bufferSize) {
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          ObjectHelper.requireNonNull(scheduler, "scheduler is null");
    //          ObjectHelper.requireNonNull(unit, "unit is null");
    //          ObjectHelper.verifyPositive(count, "count");
    //          return RxJavaPlugins.onAssembly(new FlowableWindowTimed<T>(this, timespan, timespan, unit, scheduler, count, bufferSize, restart));
    //      }

    //      public final<B> Flowable<Flowable<T>> window(Publisher<B> boundaryIndicator) {
    //          return window(boundaryIndicator, bufferSize());
    //      }

    //      public final<B> Flowable<Flowable<T>> window(Publisher<B> boundaryIndicator, int bufferSize) {
    //          ObjectHelper.requireNonNull(boundaryIndicator, "boundaryIndicator is null");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          return RxJavaPlugins.onAssembly(new FlowableWindowBoundary<T, B>(this, boundaryIndicator, bufferSize));
    //      }

    //      public final<U, V> Flowable<Flowable<T>> window(
    //          Publisher<U> openingIndicator,
    //          Function<? super U, ? extends Publisher<V>> closingIndicator) {
    //          return window(openingIndicator, closingIndicator, bufferSize());
    //      }

    //      public final<U, V> Flowable<Flowable<T>> window(
    //          Publisher<U> openingIndicator,
    //          Function<? super U, ? extends Publisher<V>> closingIndicator, int bufferSize) {
    //          ObjectHelper.requireNonNull(openingIndicator, "openingIndicator is null");
    //          ObjectHelper.requireNonNull(closingIndicator, "closingIndicator is null");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          return RxJavaPlugins.onAssembly(new FlowableWindowBoundarySelector<T, U, V>(this, openingIndicator, closingIndicator, bufferSize));
    //      }

    //      public final<B> Flowable<Flowable<T>> window(Callable<? extends Publisher<B>> boundaryIndicatorSupplier) {
    //          return window(boundaryIndicatorSupplier, bufferSize());
    //      }

    //      public final<B> Flowable<Flowable<T>> window(Callable<? extends Publisher<B>> boundaryIndicatorSupplier, int bufferSize) {
    //          ObjectHelper.requireNonNull(boundaryIndicatorSupplier, "boundaryIndicatorSupplier is null");
    //          ObjectHelper.verifyPositive(bufferSize, "bufferSize");
    //          return RxJavaPlugins.onAssembly(new FlowableWindowBoundarySupplier<T, B>(this, boundaryIndicatorSupplier, bufferSize));
    //      }

    //      public final<U, R> Flowable<R> withLatestFrom(Publisher<? extends U> other,
    //          BiFunction<? super T, ? super U, ? extends R> combiner) {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          ObjectHelper.requireNonNull(combiner, "combiner is null");

    //          return RxJavaPlugins.onAssembly(new FlowableWithLatestFrom<T, U, R>(this, combiner, other));
    //      }

    //      public final<T1, T2, R> Flowable<R> withLatestFrom(Publisher<T1> source1, Publisher<T2> source2,
    //          Function3<? super T, ? super T1, ? super T2, R> combiner) {
    //          ObjectHelper.requireNonNull(source1, "source1 is null");
    //          ObjectHelper.requireNonNull(source2, "source2 is null");
    //          Function<Object[], R> f = Functions.toFunction(combiner);
    //          return withLatestFrom(new Publisher[] { source1, source2 }, f);
    //      }

    //      public final<T1, T2, T3, R> Flowable<R> withLatestFrom(
    //          Publisher<T1> source1, Publisher<T2> source2,
    //          Publisher<T3> source3,
    //          Function4<? super T, ? super T1, ? super T2, ? super T3, R> combiner) {
    //          ObjectHelper.requireNonNull(source1, "source1 is null");
    //          ObjectHelper.requireNonNull(source2, "source2 is null");
    //          ObjectHelper.requireNonNull(source3, "source3 is null");
    //          Function<Object[], R> f = Functions.toFunction(combiner);
    //          return withLatestFrom(new Publisher[] { source1, source2, source3 }, f);
    //      }

    //      public final<T1, T2, T3, T4, R> Flowable<R> withLatestFrom(
    //          Publisher<T1> source1, Publisher<T2> source2,
    //          Publisher<T3> source3, Publisher<T4> source4,
    //          Function5<? super T, ? super T1, ? super T2, ? super T3, ? super T4, R> combiner) {
    //          ObjectHelper.requireNonNull(source1, "source1 is null");
    //          ObjectHelper.requireNonNull(source2, "source2 is null");
    //          ObjectHelper.requireNonNull(source3, "source3 is null");
    //          ObjectHelper.requireNonNull(source4, "source4 is null");
    //          Function<Object[], R> f = Functions.toFunction(combiner);
    //          return withLatestFrom(new Publisher[] { source1, source2, source3, source4 }, f);
    //      }

    //      public final<R> Flowable<R> withLatestFrom(Publisher<?>[] others, Function<? super Object[], R> combiner) {
    //          ObjectHelper.requireNonNull(others, "others is null");
    //          ObjectHelper.requireNonNull(combiner, "combiner is null");
    //          return RxJavaPlugins.onAssembly(new FlowableWithLatestFromMany<T, R>(this, others, combiner));
    //      }

    //      public final<R> Flowable<R> withLatestFrom(Iterable<? extends Publisher<?>> others, Function<? super Object[], R> combiner) {
    //          ObjectHelper.requireNonNull(others, "others is null");
    //          ObjectHelper.requireNonNull(combiner, "combiner is null");
    //          return RxJavaPlugins.onAssembly(new FlowableWithLatestFromMany<T, R>(this, others, combiner));
    //      }

    //      public final<U, R> Flowable<R> zipWith(Iterable<U> other, BiFunction<? super T, ? super U, ? extends R> zipper) {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          ObjectHelper.requireNonNull(zipper, "zipper is null");
    //          return RxJavaPlugins.onAssembly(new FlowableZipIterable<T, U, R>(this, other, zipper));
    //      }

    //      public final<U, R> Flowable<R> zipWith(Publisher<? extends U> other, BiFunction<? super T, ? super U, ? extends R> zipper) {
    //          ObjectHelper.requireNonNull(other, "other is null");
    //          return zip(this, other, zipper);
    //      }

    //      public final<U, R> Flowable<R> zipWith(Publisher<? extends U> other,
    //          BiFunction<? super T, ? super U, ? extends R> zipper, boolean delayError) {
    //          return zip(this, other, zipper, delayError);
    //      }

    //      public final<U, R> Flowable<R> zipWith(Publisher<? extends U> other,
    //          BiFunction<? super T, ? super U, ? extends R> zipper, boolean delayError, int bufferSize) {
    //          return zip(this, other, zipper, delayError, bufferSize);
    //      }

    //      // -------------------------------------------------------------------------
    //      // Fluent test support, super handy and reduces test preparation boilerplate
    //      // -------------------------------------------------------------------------
    //      public final TestSubscriber<T> test() { // NoPMD
    //          TestSubscriber<T> ts = new TestSubscriber<T>();
    //          subscribe(ts);
    //          return ts;
    //      }

    //      public final TestSubscriber<T> test(long initialRequest) { // NoPMD
    //          TestSubscriber<T> ts = new TestSubscriber<T>(initialRequest);
    //          subscribe(ts);
    //          return ts;
    //      }

    //      public final TestSubscriber<T> test(long initialRequest, boolean cancel) { // NoPMD
    //          TestSubscriber<T> ts = new TestSubscriber<T>(initialRequest);
    //          if (cancel)
    //          {
    //              ts.cancel();
    //          }
    //          subscribe(ts);
    //          return ts;
    //      }
}
