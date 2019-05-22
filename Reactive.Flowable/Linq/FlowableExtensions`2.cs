using System.Collections.Generic;

namespace Reactive.Flowable
{
    public static partial class FlowableExtensions
    {
        //public static T Flowable<T> amb(Iterable<? extends Publisher<? extends T>> sources)
        //{
        //}

        //public static T Flowable<T> ambArray(Publisher<? extends T>...sources)
        //{
        //}


        //      public static <T, R> Flowable<R> combineLatest(Publisher<? extends T>[] sources, Function<? super Object[], ? extends R> combiner)
        //      {
        //      }

        //      public static <T, R> Flowable<R> combineLatest(Function<? super Object[], ? extends R> combiner, Publisher<? extends T>...sources)
        //      {
        //      }

        //      public static <T, R> Flowable<R> combineLatest(Publisher<? extends T>[] sources, Function<? super Object[], ? extends R> combiner, int bufferSize)
        //      {
        //      }

        //      public static <T, R> Flowable<R> combineLatest(Iterable<? extends Publisher<? extends T>> sources,
        //              Function<? super Object[], ? extends R> combiner)
        //      {
        //      }

        //      public static <T, R> Flowable<R> combineLatest(Iterable<? extends Publisher<? extends T>> sources,
        //              Function<? super Object[], ? extends R> combiner, int bufferSize)
        //      {
        //      }

        //      public static <T, R> Flowable<R> combineLatestDelayError(Publisher<? extends T>[] sources,
        //              Function<? super Object[], ? extends R> combiner)
        //      {
        //      }


        //      public static <T, R> Flowable<R> combineLatestDelayError(Function<? super Object[], ? extends R> combiner,
        //              Publisher<? extends T>...sources)
        //      {
        //      }


        //      public static <T, R> Flowable<R> combineLatestDelayError(Function<? super Object[], ? extends R> combiner,
        //              int bufferSize, Publisher<? extends T>...sources)
        //      {
        //      }


        //      public static <T, R> Flowable<R> combineLatestDelayError(Publisher<? extends T>[] sources,
        //              Function<? super Object[], ? extends R> combiner, int bufferSize)
        //      {
        //      }


        //      public static <T, R> Flowable<R> combineLatestDelayError(Iterable<? extends Publisher<? extends T>> sources,
        //              Function<? super Object[], ? extends R> combiner)
        //      {
        //      }


        //      public static <T, R> Flowable<R> combineLatestDelayError(Iterable<? extends Publisher<? extends T>> sources,
        //              Function<? super Object[], ? extends R> combiner, int bufferSize)
        //      {
        //      }

        //      public static <T1, T2, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              BiFunction<? super T1, ? super T2, ? extends R> combiner)
        //      {
        //      }


        //      public static <T1, T2, T3, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              Publisher<? extends T3> source3,
        //              Function3<? super T1, ? super T2, ? super T3, ? extends R> combiner)
        //      {
        //      }

        //      public static <T1, T2, T3, T4, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              Publisher<? extends T3> source3, Publisher<? extends T4> source4,
        //              Function4<? super T1, ? super T2, ? super T3, ? super T4, ? extends R> combiner)
        //      {
        //      }

        //      public static <T1, T2, T3, T4, T5, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              Publisher<? extends T3> source3, Publisher<? extends T4> source4,
        //              Publisher<? extends T5> source5,
        //              Function5<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? extends R> combiner)
        //      {
        //      }

        //      public static <T1, T2, T3, T4, T5, T6, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              Publisher<? extends T3> source3, Publisher<? extends T4> source4,
        //              Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Function6<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? extends R> combiner)
        //      {
        //      }

        //      public static <T1, T2, T3, T4, T5, T6, T7, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              Publisher<? extends T3> source3, Publisher<? extends T4> source4,
        //              Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Publisher<? extends T7> source7,
        //              Function7<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? extends R> combiner)
        //      {
        //      }


        //      public static <T1, T2, T3, T4, T5, T6, T7, T8, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              Publisher<? extends T3> source3, Publisher<? extends T4> source4,
        //              Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Publisher<? extends T7> source7, Publisher<? extends T8> source8,
        //              Function8<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? extends R> combiner)
        //      {
        //      }

        //      public static <T1, T2, T3, T4, T5, T6, T7, T8, T9, R> Flowable<R> combineLatest(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              Publisher<? extends T3> source3, Publisher<? extends T4> source4,
        //              Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Publisher<? extends T7> source7, Publisher<? extends T8> source8,
        //              Publisher<? extends T9> source9,
        //              Function9<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? super T9, ? extends R> combiner)
        //      {
        //      }

        //      public static <T> Flowable<T> concat(Iterable<? extends Publisher<? extends T>> sources)
        //      {
        //      }

        //      public static <T> Flowable<T> concat(Publisher<? extends Publisher<? extends T>> sources)
        //      {
        //      }

        //      public static <T> Flowable<T> concat(Publisher<? extends Publisher<? extends T>> sources, int prefetch)
        //      {
        //      }

        //      public static <T> Flowable<T> concat(Publisher<? extends T> source1, Publisher<? extends T> source2)
        //      {
        //      }

        //      public static <T> Flowable<T> concat(
        //              Publisher<? extends T> source1, Publisher<? extends T> source2,
        //              Publisher<? extends T> source3)
        //      {
        //      }


        //      public static <T> Flowable<T> concat(
        //              Publisher<? extends T> source1, Publisher<? extends T> source2,
        //              Publisher<? extends T> source3, Publisher<? extends T> source4)
        //      {
        //      }


        //      public static <T> Flowable<T> concatArray(Publisher<? extends T>...sources)
        //      {
        //      }


        //      public static <T> Flowable<T> concatArrayDelayError(Publisher<? extends T>...sources)
        //      {
        //      }


        //      public static <T> Flowable<T> concatArrayEager(Publisher<? extends T>...sources)
        //      {
        //      }

        //      public static <T> Flowable<T> concatArrayEager(int maxConcurrency, int prefetch, Publisher<? extends T>...sources)
        //      {
        //      }

        //      public static <T> Flowable<T> concatArrayEagerDelayError(Publisher<? extends T>...sources)
        //      {
        //      }

        //      public static <T> Flowable<T> concatArrayEagerDelayError(int maxConcurrency, int prefetch, Publisher<? extends T>...sources)
        //      {
        //      }

        //      public static <T> Flowable<T> concatDelayError(Iterable<? extends Publisher<? extends T>> sources)
        //      {
        //      }

        //      public static <T> Flowable<T> concatDelayError(Publisher<? extends Publisher<? extends T>> sources)
        //      {
        //      }


        //      public static <T> Flowable<T> concatDelayError(Publisher<? extends Publisher<? extends T>> sources, int prefetch, boolean tillTheEnd)
        //      {
        //      }

        //      public static <T> Flowable<T> concatEager(Publisher<? extends Publisher<? extends T>> sources)
        //      {
        //      }

        //      public static <T> Flowable<T> concatEager(Publisher<? extends Publisher<? extends T>> sources, int maxConcurrency, int prefetch)
        //      {
        //      }

        //      public static <T> Flowable<T> concatEager(Iterable<? extends Publisher<? extends T>> sources)
        //      {
        //      }


        //      public static <T> Flowable<T> concatEager(Iterable<? extends Publisher<? extends T>> sources, int maxConcurrency, int prefetch)
        //      {
        //      }

        //      public static <T> Flowable<T> create(FlowableOnSubscribe<T> source, BackpressureStrategy mode)
        //      {
        //      }


        //      public static <T> Flowable<T> defer(Callable<? extends Publisher<? extends T>> supplier)
        //      {
        //      }

        //      public static <T> Flowable<T> empty()
        //      {
        //      }

        //      public static <T> Flowable<T> error(Callable<? extends Throwable> supplier)
        //      {
        //      }

        //      public static <T> Flowable<T> error(final Throwable throwable)
        //      {
        //      }

        public static IFlowable<T> ToFlowable<T>(this IEnumerable<T> items)
        {
            return new FlowableFromEnumerable<T>(items);
        }

        //      public static <T> Flowable<T> fromCallable(Callable<? extends T> supplier)
        //      {
        //      }


        //      public static <T> Flowable<T> fromFuture(Future<? extends T> future)
        //      {
        //      }


        //      public static <T> Flowable<T> fromFuture(Future<? extends T> future, long timeout, TimeUnit unit)
        //      {
        //      }

        //      public static <T> Flowable<T> fromFuture(Future<? extends T> future, long timeout, TimeUnit unit, Scheduler scheduler)
        //      {
        //      }

        //      public static <T> Flowable<T> fromFuture(Future<? extends T> future, Scheduler scheduler)
        //      {
        //      }

        //      public static <T> Flowable<T> fromIterable(Iterable<? extends T> source)
        //      {
        //      }

        //      public static <T> Flowable<T> fromPublisher(final Publisher<? extends T> source)
        //      {
        //      }

        //      public static <T> Flowable<T> generate(final Consumer<Emitter<T>> generator)
        //      {
        //      }

        //      public static <T, S> Flowable<T> generate(Callable<S> initialState, final BiConsumer<S, Emitter<T>> generator)
        //      {
        //      }

        //      public static <T, S> Flowable<T> generate(Callable<S> initialState, final BiConsumer<S, Emitter<T>> generator,
        //              Consumer<? super S> disposeState)
        //      {
        //      }

        //      public static <T, S> Flowable<T> generate(Callable<S> initialState, BiFunction<S, Emitter<T>, S> generator)
        //      {
        //      }

        //      public static <T, S> Flowable<T> generate(Callable<S> initialState, BiFunction<S, Emitter<T>, S> generator, Consumer<? super S> disposeState)
        //      {
        //      }

        //      public static Flowable<Long> interval(long initialDelay, long period, TimeUnit unit)
        //      {
        //      }

        //      public static Flowable<Long> interval(long initialDelay, long period, TimeUnit unit, Scheduler scheduler)
        //      {
        //      }

        //      public static Flowable<Long> interval(long period, TimeUnit unit)
        //      {
        //      }

        //      public static Flowable<Long> interval(long period, TimeUnit unit, Scheduler scheduler)
        //      {
        //      }

        //      public static Flowable<Long> intervalRange(long start, long count, long initialDelay, long period, TimeUnit unit)
        //      {
        //      }

        //      public static Flowable<Long> intervalRange(long start, long count, long initialDelay, long period, TimeUnit unit, Scheduler scheduler)
        //      {
        //      }

        //      public static <T> Flowable<T> just(T item)
        //      {
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2)
        //      {
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3)
        //      {
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3, T item4)
        //      {
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3, T item4, T item5)
        //      {
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3, T item4, T item5, T item6)
        //      {
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3, T item4, T item5, T item6, T item7)
        //      {
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3, T item4, T item5, T item6, T item7, T item8)
        //      {
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3, T item4, T item5, T item6, T item7, T item8, T item9)
        //      {
        //      }

        //      public static <T> Flowable<T> just(T item1, T item2, T item3, T item4, T item5, T item6, T item7, T item8, T item9, T item10)
        //      {
        //      }

        //      public static <T> Flowable<T> merge(Iterable<? extends Publisher<? extends T>> sources, int maxConcurrency, int bufferSize)
        //      {
        //      }

        //      public static <T> Flowable<T> mergeArray(int maxConcurrency, int bufferSize, Publisher<? extends T>...sources)
        //      {
        //      }

        //      public static <T> Flowable<T> merge(Iterable<? extends Publisher<? extends T>> sources)
        //      {
        //      }

        //      public static <T> Flowable<T> merge(Iterable<? extends Publisher<? extends T>> sources, int maxConcurrency)
        //      {
        //      }

        //      public static <T> Flowable<T> merge(Publisher<? extends Publisher<? extends T>> sources)
        //      {
        //      }

        //      public static <T> Flowable<T> merge(Publisher<? extends Publisher<? extends T>> sources, int maxConcurrency)
        //      {
        //      }

        //      public static <T> Flowable<T> mergeArray(Publisher<? extends T>...sources)
        //      {
        //      }

        //      public static <T> Flowable<T> merge(Publisher<? extends T> source1, Publisher<? extends T> source2)
        //      {
        //      }

        //      public static <T> Flowable<T> merge(Publisher<? extends T> source1, Publisher<? extends T> source2, Publisher<? extends T> source3)
        //      {
        //      }

        //      public static <T> Flowable<T> merge(
        //              Publisher<? extends T> source1, Publisher<? extends T> source2,
        //              Publisher<? extends T> source3, Publisher<? extends T> source4)
        //      {
        //      }

        //      public static <T> Flowable<T> mergeDelayError(Iterable<? extends Publisher<? extends T>> sources)
        //      {
        //      }

        //      public static <T> Flowable<T> mergeDelayError(Iterable<? extends Publisher<? extends T>> sources, int maxConcurrency, int bufferSize)
        //      {
        //      }

        //      public static <T> Flowable<T> mergeArrayDelayError(int maxConcurrency, int bufferSize, Publisher<? extends T>...sources)
        //      {
        //      }

        //      public static <T> Flowable<T> mergeDelayError(Iterable<? extends Publisher<? extends T>> sources, int maxConcurrency)
        //      {
        //      }

        //      public static <T> Flowable<T> mergeDelayError(Publisher<? extends Publisher<? extends T>> sources)
        //      {
        //      }

        //      public static <T> Flowable<T> mergeDelayError(Publisher<? extends Publisher<? extends T>> sources, int maxConcurrency)
        //      {
        //      }

        //      public static <T> Flowable<T> mergeArrayDelayError(Publisher<? extends T>...sources)
        //      {
        //      }

        //      public static <T> Flowable<T> mergeDelayError(Publisher<? extends T> source1, Publisher<? extends T> source2)
        //      {
        //      }

        //      public static <T> Flowable<T> mergeDelayError(Publisher<? extends T> source1, Publisher<? extends T> source2, Publisher<? extends T> source3)
        //      {
        //      }

        //      public static <T> Flowable<T> mergeDelayError(
        //              Publisher<? extends T> source1, Publisher<? extends T> source2,
        //              Publisher<? extends T> source3, Publisher<? extends T> source4)
        //      {
        //      }

        //      public static <T> Flowable<T> never()
        //      {
        //      }

        //      public static Flowable<Integer> range(int start, int count)
        //      {
        //      }

        //      public static Flowable<Long> rangeLong(long start, long count)
        //      {
        //      }

        //      public static <T> Single<Boolean> sequenceEqual(Publisher<? extends T> source1, Publisher<? extends T> source2)
        //      {
        //      }

        //      public static <T> Single<Boolean> sequenceEqual(Publisher<? extends T> source1, Publisher<? extends T> source2,
        //              BiPredicate<? super T, ? super T> isEqual)
        //      {
        //      }

        //      public static <T> Single<Boolean> sequenceEqual(Publisher<? extends T> source1, Publisher<? extends T> source2,
        //              BiPredicate<? super T, ? super T> isEqual, int bufferSize)
        //      {
        //      }

        //      public static <T> Single<Boolean> sequenceEqual(Publisher<? extends T> source1, Publisher<? extends T> source2, int bufferSize)
        //      {
        //      }

        //      public static <T> Flowable<T> switchOnNext(Publisher<? extends Publisher<? extends T>> sources, int bufferSize)
        //      {
        //      }

        //      public static <T> Flowable<T> switchOnNext(Publisher<? extends Publisher<? extends T>> sources)
        //      {
        //      }

        //      public static <T> Flowable<T> switchOnNextDelayError(Publisher<? extends Publisher<? extends T>> sources)
        //      {
        //      }

        //      public static <T> Flowable<T> switchOnNextDelayError(Publisher<? extends Publisher<? extends T>> sources, int prefetch)
        //      {
        //      }

        //      public static Flowable<Long> timer(long delay, TimeUnit unit)
        //      {
        //      }

        //      public static Flowable<Long> timer(long delay, TimeUnit unit, Scheduler scheduler)
        //      {
        //      }

        //      public static <T> Flowable<T> unsafeCreate(Publisher<T> onSubscribe)
        //      {
        //      }

        //      public static <T, D> Flowable<T> Using(Callable<? extends D> resourceSupplier,
        //              Function<? super D, ? extends Publisher<? extends T>> sourceSupplier, Consumer<? super D> resourceDisposer) 
        //      {
        //      }

        //      public static <T, D> Flowable<T> Using(Callable<? extends D> resourceSupplier,
        //              Function<? super D, ? extends Publisher<? extends T>> sourceSupplier,
        //                      Consumer<? super D> resourceDisposer, boolean eager)
        //      {
        //      }


        //      public static <T, R> Flowable<R> zip(Iterable<? extends Publisher<? extends T>> sources, Function<? super Object[], ? extends R> zipper)
        //      {
        //      }

        //      public static <T, R> Flowable<R> zip(Publisher<? extends Publisher<? extends T>> sources,
        //              final Function<? super Object[], ? extends R> zipper)
        //      {
        //      }

        //      public static <T1, T2, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              BiFunction<? super T1, ? super T2, ? extends R> zipper)
        //      {
        //      }

        //      public static <T1, T2, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              BiFunction<? super T1, ? super T2, ? extends R> zipper, boolean delayError)
        //      {
        //      }

        //      public static <T1, T2, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2,
        //              BiFunction<? super T1, ? super T2, ? extends R> zipper, boolean delayError, int bufferSize)
        //      {
        //      }

        //      public static <T1, T2, T3, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2, Publisher<? extends T3> source3,
        //              Function3<? super T1, ? super T2, ? super T3, ? extends R> zipper)
        //      {
        //      }

        //      public static <T1, T2, T3, T4, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2, Publisher<? extends T3> source3,
        //              Publisher<? extends T4> source4,
        //              Function4<? super T1, ? super T2, ? super T3, ? super T4, ? extends R> zipper)
        //      { 
        //      }

        //      public static <T1, T2, T3, T4, T5, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2, Publisher<? extends T3> source3,
        //              Publisher<? extends T4> source4, Publisher<? extends T5> source5,
        //              Function5<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? extends R> zipper)
        //      { 
        //      }

        //      public static <T1, T2, T3, T4, T5, T6, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2, Publisher<? extends T3> source3,
        //              Publisher<? extends T4> source4, Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Function6<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? extends R> zipper)
        //      { 
        //      }

        //      public static <T1, T2, T3, T4, T5, T6, T7, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2, Publisher<? extends T3> source3,
        //              Publisher<? extends T4> source4, Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Publisher<? extends T7> source7,
        //              Function7<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? extends R> zipper)
        //      { 
        //      }


        //      public static <T1, T2, T3, T4, T5, T6, T7, T8, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2, Publisher<? extends T3> source3,
        //              Publisher<? extends T4> source4, Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Publisher<? extends T7> source7, Publisher<? extends T8> source8,
        //              Function8<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? extends R> zipper)
        //      { 
        //      }

        //      public static <T1, T2, T3, T4, T5, T6, T7, T8, T9, R> Flowable<R> zip(
        //              Publisher<? extends T1> source1, Publisher<? extends T2> source2, Publisher<? extends T3> source3,
        //              Publisher<? extends T4> source4, Publisher<? extends T5> source5, Publisher<? extends T6> source6,
        //              Publisher<? extends T7> source7, Publisher<? extends T8> source8, Publisher<? extends T9> source9,
        //              Function9<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super T6, ? super T7, ? super T8, ? super T9, ? extends R> zipper)
        //      { 
        //      }


        //      public static <T, R> Flowable<R> zipArray(Function<? super Object[], ? extends R> zipper,
        //              boolean delayError, int bufferSize, Publisher<? extends T>...sources)
        //      { 
        //      }

        //      public static <T, R> Flowable<R> zipIterable(Iterable<? extends Publisher<? extends T>> sources,
        //              Function<? super Object[], ? extends R> zipper, boolean delayError,
        //              int bufferSize)
        //      { 
        //      }
    }

    //      public static int bufferSize()
    //      { 
    //      }


    //      //// ***************************************************************************************************
    //      //// Instance operators
    //      //// ***************************************************************************************************

    //      public final Single<Boolean> All(Predicate<? super T> predicate)    
    //      { 
    //      }

    //      public final Flowable<T> ambWith(Publisher<? extends T> other)
    //      { 
    //      }

    //      public final Single<Boolean> any(Predicate<? super T> predicate)
    //      { 
    //      }

    //      public final<R> R As(@NonNull FlowableConverter<T, ? extends R> converter)
    //      { 
    //      }

    //      public final T blockingFirst()
    //      { 
    //      }

    //      public final T blockingFirst(T defaultItem)
    //      { 
    //      }

    //      public final void blockingForEach(Consumer<? super T> onNext)
    //      { 
    //      }

    //      public final Iterable<T> blockingIterable()
    //      {
    //      }

    //      public final Iterable<T> blockingIterable(int bufferSize)
    //      { 
    //      }

    //      public final T blockingLast()
    //      { 
    //      }

    //      public final T blockingLast(T defaultItem)
    //      { 
    //      }

    //      public final Iterable<T> blockingLatest()
    //      { 
    //      }

    //      public final Iterable<T> blockingMostRecent(T initialItem)
    //      { 
    //      }

    //      public final Iterable<T> blockingNext()
    //      { 
    //      }

    //      public final T blockingSingle()
    //      { 
    //      }

    //      public final T blockingSingle(T defaultItem)
    //      { 
    //      }

    //      public final Future<T> toFuture()
    //      { 
    //      }

    //      public final void blockingSubscribe()
    //      { 
    //      }

    //      public final void blockingSubscribe(Consumer<? super T> onNext)
    //      { 
    //      }

    //      public final void blockingSubscribe(Consumer<? super T> onNext, int bufferSize)
    //      { 
    //      }

    //      public final void blockingSubscribe(Consumer<? super T> onNext, Consumer<? super Throwable> onError)
    //      { 
    //      }

    //      public final void blockingSubscribe(Consumer<? super T> onNext, Consumer<? super Throwable> onError,
    //          int bufferSize)
    //      { 
    //      }

    //      public final void blockingSubscribe(Consumer<? super T> onNext, Consumer<? super Throwable> onError, Action onComplete)
    //      { 
    //      }

    //      public final void blockingSubscribe(Consumer<? super T> onNext, Consumer<? super Throwable> onError, Action onComplete,
    //          int bufferSize)
    //      { 
    //      }

    //      public final void blockingSubscribe(Subscriber<? super T> subscriber)
    //      { 
    //      }

    //      public final Flowable<List<T>> buffer(int count)
    //      { 
    //      }

    //      public final Flowable<List<T>> buffer(int count, int skip)
    //      { 
    //      }

    //      public final<U extends Collection<? super T>> Flowable<U> buffer(int count, int skip, Callable<U> bufferSupplier)
    //      { 
    //      }

    //      public final<U extends Collection<? super T>> Flowable<U> buffer(int count, Callable<U> bufferSupplier)
    //      { 
    //      }

    //      public final Flowable<List<T>> buffer(long timespan, long timeskip, TimeUnit unit)
    //      { 
    //      }

    //      public final Flowable<List<T>> buffer(long timespan, long timeskip, TimeUnit unit, Scheduler scheduler)
    //      { 
    //      }

    //      public final<U extends Collection<? super T>> Flowable<U> buffer(long timespan, long timeskip, TimeUnit unit,
    //              Scheduler scheduler, Callable<U> bufferSupplier)
    //      { 
    //      }

    //      public final Flowable<List<T>> buffer(long timespan, TimeUnit unit)
    //      { 
    //      }

    //      public final Flowable<List<T>> buffer(long timespan, TimeUnit unit, int count)
    //      { 
    //      }

    //      public final Flowable<List<T>> buffer(long timespan, TimeUnit unit, Scheduler scheduler, int count)
    //      { 
    //      }

    //      public final<U extends Collection<? super T>> Flowable<U> buffer(
    //              long timespan, TimeUnit unit,
    //              Scheduler scheduler, int count,
    //              Callable<U> bufferSupplier,
    //              boolean restartTimerOnMaxSize)
    //      { 
    //      }

    //      public final Flowable<List<T>> buffer(long timespan, TimeUnit unit, Scheduler scheduler)
    //      { 
    //      }

    //      public final<TOpening, TClosing> Flowable<List<T>> buffer(
    //              Flowable<? extends TOpening> openingIndicator,
    //              Function<? super TOpening, ? extends Publisher<? extends TClosing>> closingIndicator)
    //      { 
    //      }

    //      public final<TOpening, TClosing, U extends Collection<? super T>> Flowable<U> buffer(
    //              Flowable<? extends TOpening> openingIndicator,
    //              Function<? super TOpening, ? extends Publisher<? extends TClosing>> closingIndicator,
    //              Callable<U> bufferSupplier)
    //      { 
    //      }

    //      public final<B> Flowable<List<T>> buffer(Publisher<B> boundaryIndicator)
    //      { 
    //      }

    //      public final<B> Flowable<List<T>> buffer(Publisher<B> boundaryIndicator, final int initialCapacity)
    //      { 
    //      }

    //      public final<B, U extends Collection<? super T>> Flowable<U> buffer(Publisher<B> boundaryIndicator, Callable<U> bufferSupplier)
    //      { 
    //      }

    //      public final<B> Flowable<List<T>> buffer(Callable<? extends Publisher<B>> boundaryIndicatorSupplier)
    //      { 
    //      }

    //      public final<B, U extends Collection<? super T>> Flowable<U> buffer(Callable<? extends Publisher<B>> boundaryIndicatorSupplier,
    //              Callable<U> bufferSupplier)
    //      { 
    //      }

    //      public final Flowable<T> cache()
    //      { 
    //      }

    //      public final Flowable<T> cacheWithInitialCapacity(int initialCapacity)
    //      { 
    //      }

    //      public final<U> Flowable<U> cast(final Class<U> clazz)
    //      { 
    //      }


    //      public final<U> Single<U> collect(Callable<? extends U> initialItemSupplier, BiConsumer<? super U, ? super T> collector)
    //      { 
    //      }

    //      public final<U> Single<U> collectInto(final U initialItem, BiConsumer<? super U, ? super T> collector)
    //      { 
    //      }

    //      public final<R> Flowable<R> compose(FlowableTransformer<? super T, ? extends R> composer)
    //      { 
    //      }

    //      public final<R> Flowable<R> concatMap(Function<? super T, ? extends Publisher<? extends R>> mapper)
    //      { 
    //      }

    //      public final<R> Flowable<R> concatMap(Function<? super T, ? extends Publisher<? extends R>> mapper, int prefetch)
    //      { 
    //      }

    //      public final Completable concatMapCompletable(Function<? super T, ? extends CompletableSource> mapper)
    //      { 
    //      }

    //      public final Completable concatMapCompletable(Function<? super T, ? extends CompletableSource> mapper, int prefetch)
    //      { 
    //      }

    //      public final Completable concatMapCompletableDelayError(Function<? super T, ? extends CompletableSource> mapper)
    //      { 
    //      }

    //      public final Completable concatMapCompletableDelayError(Function<? super T, ? extends CompletableSource> mapper, boolean tillTheEnd)
    //      { 
    //      }

    //      public final Completable concatMapCompletableDelayError(Function<? super T, ? extends CompletableSource> mapper, boolean tillTheEnd, int prefetch)
    //      { 
    //      }

    //      public final<R> Flowable<R> concatMapDelayError(Function<? super T, ? extends Publisher<? extends R>> mapper)
    //      { 
    //      }

    //      public final<R> Flowable<R> concatMapDelayError(Function<? super T, ? extends Publisher<? extends R>> mapper,
    //              int prefetch, boolean tillTheEnd)
    //      { 
    //      }

    //      public final<R> Flowable<R> concatMapEager(Function<? super T, ? extends Publisher<? extends R>> mapper)
    //      { 
    //      }

    //      public final<R> Flowable<R> concatMapEager(Function<? super T, ? extends Publisher<? extends R>> mapper,
    //              int maxConcurrency, int prefetch)
    //      { 
    //      }

    //      public final<R> Flowable<R> concatMapEagerDelayError(Function<? super T, ? extends Publisher<? extends R>> mapper,
    //              boolean tillTheEnd)
    //      { 
    //      }

    //      public final<R> Flowable<R> concatMapEagerDelayError(Function<? super T, ? extends Publisher<? extends R>> mapper,
    //              int maxConcurrency, int prefetch, boolean tillTheEnd)
    //      { 
    //      }

    //      public final<U> Flowable<U> concatMapIterable(Function<? super T, ? extends Iterable<? extends U>> mapper)
    //      { 
    //      }

    //      public final<U> Flowable<U> concatMapIterable(final Function<? super T, ? extends Iterable<? extends U>> mapper, int prefetch)
    //      { 
    //      }

    //public final<R> Flowable<R> concatMapMaybe(Function<? super T, ? extends MaybeSource<? extends R>> mapper) 
    //      { 
    //      }

    //public final<R> Flowable<R> concatMapMaybe(Function<? super T, ? extends MaybeSource<? extends R>> mapper, int prefetch) 
    //      {
    //      }

    //public final<R> Flowable<R> concatMapMaybeDelayError(Function<? super T, ? extends MaybeSource<? extends R>> mapper) 
    //      {
    //      }

    //public final<R> Flowable<R> concatMapMaybeDelayError(Function<? super T, ? extends MaybeSource<? extends R>> mapper, boolean tillTheEnd) 
    //      {
    //      }

    //public final<R> Flowable<R> concatMapMaybeDelayError(Function<? super T, ? extends MaybeSource<? extends R>> mapper, boolean tillTheEnd, int prefetch) 
    //      { 
    //      }

    //public final<R> Flowable<R> concatMapSingle(Function<? super T, ? extends SingleSource<? extends R>> mapper) 
    //{ 
    //      }

    //public final<R> Flowable<R> concatMapSingle(Function<? super T, ? extends SingleSource<? extends R>> mapper, int prefetch) 
    //{
    //      }

    //public final<R> Flowable<R> concatMapSingleDelayError(Function<? super T, ? extends SingleSource<? extends R>> mapper) 
    //{ 
    //      }

    //public final<R> Flowable<R> concatMapSingleDelayError(Function<? super T, ? extends SingleSource<? extends R>> mapper, boolean tillTheEnd) 
    //{ 
    //      }

    //public final<R> Flowable<R> concatMapSingleDelayError(Function<? super T, ? extends SingleSource<? extends R>> mapper, boolean tillTheEnd, int prefetch) 
    //{
    //}

    //public final Flowable<T> concatWith(Publisher<? extends T> other)
    //{
    //}

    //public final Flowable<T> concatWith(@NonNull SingleSource<? extends T> other)
    //      { 
    //      }

    //public final Flowable<T> concatWith(@NonNull MaybeSource<? extends T> other)
    //      { 
    //      }

    //public final Flowable<T> concatWith(@NonNull CompletableSource other)
    //      { 
    //      }

    //public final Single<Boolean> contains(final Object item)
    //      { 
    //      }

    //public final Single<Long> count() 
    //{ 
    //      }

    //public final<U> Flowable<T> debounce(Function<? super T, ? extends Publisher<U>> debounceIndicator) 
    //{ 
    //      }

    //public final Flowable<T> debounce(long timeout, TimeUnit unit) 
    //{ 
    //      }

    //public final Flowable<T> debounce(long timeout, TimeUnit unit, Scheduler scheduler) 
    //{ 
    //      }

    //public final Flowable<T> defaultIfEmpty(T defaultItem) 
    //{ 
    //      }

    //public final<U> Flowable<T> delay(final Function<? super T, ? extends Publisher<U>> itemDelayIndicator)
    //      { 
    //      }

    //public final Flowable<T> delay(long delay, TimeUnit unit) 
    //{ 
    //      }

    //public final Flowable<T> delay(long delay, TimeUnit unit, boolean delayError) 
    //{ 
    //      }

    //public final Flowable<T> delay(long delay, TimeUnit unit, Scheduler scheduler) { 
    //      }

    //public final Flowable<T> delay(long delay, TimeUnit unit, Scheduler scheduler, boolean delayError) 
    //{ 
    //      }

    //public final<U, V> Flowable<T> delay(Publisher<U> subscriptionIndicator,
    //          Function<? super T, ? extends Publisher<V>> itemDelayIndicator) 
    //{ 
    //      }

    //public final<U> Flowable<T> delaySubscription(Publisher<U> subscriptionIndicator) 
    //{ 
    //      }

    //public final Flowable<T> delaySubscription(long delay, TimeUnit unit) 
    //{ 
    //      }

    //public final Flowable<T> delaySubscription(long delay, TimeUnit unit, Scheduler scheduler) { 
    //      }

    //public final<T2> Flowable<T2> dematerialize() 
    //{ 
    //      }

    //public final<R> Flowable<R> dematerialize(Function<? super T, Notification<R>> selector) 
    //{ 
    //      }

    //public final Flowable<T> distinct() 
    //{ 
    //      }

    //public final<K> Flowable<T> distinct(Function<? super T, K> keySelector) { 
    //      }

    //public final<K> Flowable<T> distinct(Function<? super T, K> keySelector,
    //		Callable<? extends Collection<? super K>> collectionSupplier) 
    //{ 
    //      }

    //public final Flowable<T> distinctUntilChanged() 
    //{ 
    //      }

    //public final<K> Flowable<T> distinctUntilChanged(Function<? super T, K> keySelector) 
    //{ 
    //      }

    //public final Flowable<T> distinctUntilChanged(BiPredicate<? super T, ? super T> comparer) 
    //{ 
    //      }

    //public final Flowable<T> doFinally(Action onFinally) 
    //{ 
    //      }

    //public final Flowable<T> doAfterNext(Consumer<? super T> onAfterNext) 
    //{ 
    //      }

    //public final Flowable<T> doAfterTerminate(Action onAfterTerminate) 
    //{ 
    //      }

    //public final Flowable<T> doOnCancel(Action onCancel) 
    //{ 
    //      }

    //public final Flowable<T> doOnComplete(Action onComplete) 
    //{ 
    //      }

    //private Flowable<T> doOnEach(Consumer<? super T> onNext, Consumer<? super Throwable> onError,
    //		Action onComplete, Action onAfterTerminate)
    //      { 
    //      }

    //public final Flowable<T> doOnEach(final Consumer<? super Notification<T>> onNotification)
    //      {  
    //      }

    //public final Flowable<T> doOnEach(final Subscriber<? super T> subscriber)
    //      { 
    //      }

    //public final Flowable<T> doOnError(Consumer<? super Throwable> onError) 
    //{ 
    //      }

    //public final Flowable<T> doOnLifecycle(final Consumer<? super Subscription> onSubscribe,
    //          final LongConsumer onRequest, final Action onCancel)
    //      { 
    //      }

    //public final Flowable<T> doOnNext(Consumer<? super T> onNext) 
    //{ 
    //      }

    //public final Flowable<T> doOnRequest(LongConsumer onRequest) 
    //{ 
    //      }

    //public final Flowable<T> doOnSubscribe(Consumer<? super Subscription> onSubscribe) 
    //{ 
    //      }

    //public final Flowable<T> doOnTerminate(final Action onTerminate)
    //      { 
    //      }

    //public final Maybe<T> elementAt(long index) 
    //{ 
    //      }

    //public final Single<T> elementAt(long index, T defaultItem) 
    //{ 
    //      }

    //public final Single<T> elementAtOrError(long index)
    //{ 
    //      }

    //public final Flowable<T> filter(Predicate<? super T> predicate) 
    //{ 
    //      }

    //public final Maybe<T> firstElement() 
    //{ 
    //      }

    //public final Single<T> first(T defaultItem) 
    //{ 
    //      }

    //public final Single<T> firstOrError() 
    //{ 
    //      }

    //public final<R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends R>> mapper) 
    //{ 
    //      }

    //public final<R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends R>> mapper, boolean delayErrors) 
    //{ 
    //      }

    //public final<R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends R>> mapper, int maxConcurrency) 
    //{ 
    //      }

    //public final<R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends R>> mapper, boolean delayErrors, int maxConcurrency) 
    //{ 
    //      }

    //public final<R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends R>> mapper,
    //		boolean delayErrors, int maxConcurrency, int bufferSize) 
    //{ 
    //      }

    //public final<R> Flowable<R> flatMap(
    //		Function<? super T, ? extends Publisher<? extends R>> onNextMapper,
    //		Function<? super Throwable, ? extends Publisher<? extends R>> onErrorMapper,
    //		Callable<? extends Publisher<? extends R>> onCompleteSupplier) 
    //{ 
    //      }

    //public final<R> Flowable<R> flatMap(
    //		Function<? super T, ? extends Publisher<? extends R>> onNextMapper,
    //		Function<Throwable, ? extends Publisher<? extends R>> onErrorMapper,
    //		Callable<? extends Publisher<? extends R>> onCompleteSupplier,
    //		int maxConcurrency) 
    //{ 
    //}

    //public final<U, R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends U>> mapper,
    //		BiFunction<? super T, ? super U, ? extends R> combiner) 
    //{ 
    //      }

    //public final<U, R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends U>> mapper,
    //          BiFunction<? super T, ? super U, ? extends R> combiner, boolean delayErrors) 
    //{
    //      }

    //public final<U, R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends U>> mapper,
    //		BiFunction<? super T, ? super U, ? extends R> combiner, boolean delayErrors, int maxConcurrency) 
    //{ 
    //      }

    //public final<U, R> Flowable<R> flatMap(final Function<? super T, ? extends Publisher<? extends U>> mapper,
    //		final BiFunction<? super T, ? super U, ? extends R> combiner, boolean delayErrors, int maxConcurrency, int bufferSize)
    //      { 
    //      }

    //public final<U, R> Flowable<R> flatMap(Function<? super T, ? extends Publisher<? extends U>> mapper,
    //          BiFunction<? super T, ? super U, ? extends R> combiner, int maxConcurrency) 
    //{ 
    //      }

    //public final Completable flatMapCompletable(Function<? super T, ? extends CompletableSource> mapper)
    //      { 
    //      }

    //public final Completable flatMapCompletable(Function<? super T, ? extends CompletableSource> mapper, boolean delayErrors, int maxConcurrency)
    //      { 
    //      }

    //      public final<U> Flowable<U> flatMapIterable(final Function<? super T, ? extends Iterable<? extends U>> mapper)
    //      { 
    //      }

    //      public final<U> Flowable<U> flatMapIterable(final Function<? super T, ? extends Iterable<? extends U>> mapper, int bufferSize)
    //      { 
    //      }

    //      public final<U, V> Flowable<V> flatMapIterable(final Function<? super T, ? extends Iterable<? extends U>> mapper,
    //          final BiFunction<? super T, ? super U, ? extends V> resultSelector)
    //      { 
    //      }

    //      public final<U, V> Flowable<V> flatMapIterable(final Function<? super T, ? extends Iterable<? extends U>> mapper,
    //          final BiFunction<? super T, ? super U, ? extends V> resultSelector, int prefetch)
    //      {
    //      }

    //      public final<R> Flowable<R> flatMapMaybe(Function<? super T, ? extends MaybeSource<? extends R>> mapper) {
    //          return flatMapMaybe(mapper, false, Integer.MAX_VALUE);
    //      }

    //      public final<R> Flowable<R> flatMapMaybe(Function<? super T, ? extends MaybeSource<? extends R>> mapper, boolean delayErrors, int maxConcurrency) 
    //      {
    //      }

    //      public final<R> Flowable<R> flatMapSingle(Function<? super T, ? extends SingleSource<? extends R>> mapper) {
    //      }

    //      public final<R> Flowable<R> flatMapSingle(Function<? super T, ? extends SingleSource<? extends R>> mapper, boolean delayErrors, int maxConcurrency) {
    //      }

    //      public final Disposable forEach(Consumer<? super T> onNext)
    //      {
    //      }

    //      public final Disposable forEachWhile(Predicate<? super T> onNext)
    //      {
    //      }

    //      public final Disposable forEachWhile(Predicate<? super T> onNext, Consumer<? super Throwable> onError)
    //      { 
    //      }

    //      public final Disposable forEachWhile(final Predicate<? super T> onNext, final Consumer<? super Throwable> onError,
    //          final Action onComplete)
    //      { 
    //      }

    //      public final<K> Flowable<GroupedFlowable<K, T>> groupBy(Function<? super T, ? extends K> keySelector) { 
    //      }

    //      public final<K> Flowable<GroupedFlowable<K, T>> groupBy(Function<? super T, ? extends K> keySelector, boolean delayError) { 
    //      }

    //      public final<K, V> Flowable<GroupedFlowable<K, V>> groupBy(Function<? super T, ? extends K> keySelector,
    //          Function<? super T, ? extends V> valueSelector) { 
    //      }

    //      public final<K, V> Flowable<GroupedFlowable<K, V>> groupBy(Function<? super T, ? extends K> keySelector,
    //          Function<? super T, ? extends V> valueSelector, boolean delayError) { 
    //      }

    //      public final<K, V> Flowable<GroupedFlowable<K, V>> groupBy(Function<? super T, ? extends K> keySelector,
    //          Function<? super T, ? extends V> valueSelector,
    //          boolean delayError, int bufferSize) 
    //{ 
    //      }

    //      public final<K, V> Flowable<GroupedFlowable<K, V>> groupBy(Function<? super T, ? extends K> keySelector,
    //          Function<? super T, ? extends V> valueSelector,
    //          boolean delayError, int bufferSize,
    //          Function<? super Consumer<Object>, ? extends Map<K, Object>> evictingMapFactory) {
    //      }

    //      public final<TRight, TLeftEnd, TRightEnd, R> Flowable<R> groupJoin(
    //          Publisher<? extends TRight> other,
    //          Function<? super T, ? extends Publisher<TLeftEnd>> leftEnd,
    //          Function<? super TRight, ? extends Publisher<TRightEnd>> rightEnd,
    //          BiFunction<? super T, ? super Flowable<TRight>, ? extends R> resultSelector) {
    //      }

    //      public final Flowable<T> hide() {
    //      }

    //      public final Completable ignoreElements()
    //      {
    //      }

    //      public final Single<Boolean> isEmpty() {
    //      }

    //      public final<TRight, TLeftEnd, TRightEnd, R> Flowable<R> join(
    //          Publisher<? extends TRight> other,
    //          Function<? super T, ? extends Publisher<TLeftEnd>> leftEnd,
    //          Function<? super TRight, ? extends Publisher<TRightEnd>> rightEnd,
    //          BiFunction<? super T, ? super TRight, ? extends R> resultSelector) 
    //{
    //      }

    //      public final Maybe<T> lastElement() {
    //      }

    //      public final Single<T> last(T defaultItem) {
    //      }

    //      public final Single<T> lastOrError() {
    //          return RxJavaPlugins.onAssembly(new FlowableLastSingle<T>(this, null));
    //      }

    //      public final<R> Flowable<R> lift(FlowableOperator<? extends R, ? super T> lifter) {
    //      }

    //      public final Flowable<T> limit(long count) 
    //{ 
    //      }

    //      public final<R> Flowable<R> map(Function<? super T, ? extends R> mapper) { 
    //      }

    //      public final Flowable<Notification<T>> materialize() { 
    //      }

    //      public final Flowable<T> mergeWith(Publisher<? extends T> other) { 
    //      }

    //      public final Flowable<T> mergeWith(@NonNull SingleSource<? extends T> other)
    //      { 
    //      }

    //      public final Flowable<T> mergeWith(@NonNull MaybeSource<? extends T> other)
    //      {
    //      }

    //      public final Flowable<T> mergeWith(@NonNull CompletableSource other)
    //      { 
    //      }

    //      public final Flowable<T> observeOn(Scheduler scheduler) { 
    //      }

    //      public final Flowable<T> observeOn(Scheduler scheduler, boolean delayError) { 
    //      }

    //      public final Flowable<T> observeOn(Scheduler scheduler, boolean delayError, int bufferSize) { 
    //      }

    //      public final<U> Flowable<U> ofType(final Class<U> clazz)
    //      { 
    //      }

    //      public final Flowable<T> onBackpressureBuffer() { 
    //      }

    //      public final Flowable<T> onBackpressureBuffer(boolean delayError) { 
    //      }

    //      public final Flowable<T> onBackpressureBuffer(int capacity) { 
    //      }

    //      public final Flowable<T> onBackpressureBuffer(int capacity, boolean delayError) {
    //      }

    //      public final Flowable<T> onBackpressureBuffer(int capacity, boolean delayError, boolean unbounded) { 
    //      }

    //      public final Flowable<T> onBackpressureBuffer(int capacity, boolean delayError, boolean unbounded,
    //          Action onOverflow) { 
    //      }

    //      public final Flowable<T> onBackpressureBuffer(int capacity, Action onOverflow) { 
    //      }

    //      public final Flowable<T> onBackpressureBuffer(long capacity, Action onOverflow, BackpressureOverflowStrategy overflowStrategy) { 
    //      }

    //      public final Flowable<T> onBackpressureDrop() 
    //{ 
    //      }

    //      public final Flowable<T> onBackpressureDrop(Consumer<? super T> onDrop) 
    //{ 
    //      }

    //      public final Flowable<T> onBackpressureLatest() 
    //{ 
    //      }

    //      public final Flowable<T> onErrorResumeNext(Function<? super Throwable, ? extends Publisher<? extends T>> resumeFunction) 
    //{ 
    //      }

    //      public final Flowable<T> onErrorResumeNext(final Publisher<? extends T> next)
    //      { 
    //      }

    //      public final Flowable<T> onErrorReturn(Function<? super Throwable, ? extends T> valueSupplier) 
    //{ 
    //      }

    //      public final Flowable<T> onErrorReturnItem(final T item)
    //      { 
    //      }

    //      public final Flowable<T> onExceptionResumeNext(final Publisher<? extends T> next)
    //      { 
    //      }

    //      public final Flowable<T> onTerminateDetach()
    //{ 
    //      }

    //      public final ParallelFlowable<T> parallel() 
    //{ 
    //      }

    //      public final ParallelFlowable<T> parallel(int parallelism) 
    //{ 
    //      }

    //      public final ParallelFlowable<T> parallel(int parallelism, int prefetch) { 
    //      }

    //      public final ConnectableFlowable<T> publish() { 
    //      }

    //      public final<R> Flowable<R> publish(Function<? super Flowable<T>, ? extends Publisher<R>> selector) { 
    //      }

    //      public final<R> Flowable<R> publish(Function<? super Flowable<T>, ? extends Publisher<? extends R>> selector, int prefetch) {  
    //      }

    //      public final ConnectableFlowable<T> publish(int bufferSize) { 
    //      }

    //      public final Flowable<T> rebatchRequests(int n) { 
    //      }

    //      public final Maybe<T> reduce(BiFunction<T, T, T> reducer) { 
    //      }

    //      public final<R> Single<R> reduce(R seed, BiFunction<R, ? super T, R> reducer) { 
    //      }

    //      public final<R> Single<R> reduceWith(Callable<R> seedSupplier, BiFunction<R, ? super T, R> reducer) { 
    //      }

    //      public final Flowable<T> repeat() { 
    //      }

    //      public final Flowable<T> repeat(long times) 
    //{ 
    //      }

    //      public final Flowable<T> repeatUntil(BooleanSupplier stop) 
    //{ 
    //      }

    //      public final Flowable<T> repeatWhen(final Function<? super Flowable<Object>, ? extends Publisher<?>> handler)
    //      { 
    //      }

    //      public final ConnectableFlowable<T> replay() { 
    //      }

    //      public final<R> Flowable<R> replay(Function<? super Flowable<T>, ? extends Publisher<R>> selector) { 
    //      }

    //      public final<R> Flowable<R> replay(Function<? super Flowable<T>, ? extends Publisher<R>> selector, final int bufferSize)
    //      { 
    //      }

    //      public final<R> Flowable<R> replay(Function<? super Flowable<T>, ? extends Publisher<R>> selector, int bufferSize, long time, TimeUnit unit) {
    //      }

    //      public final<R> Flowable<R> replay(Function<? super Flowable<T>, ? extends Publisher<R>> selector, final int bufferSize, final long time, final TimeUnit unit, final Scheduler scheduler)
    //      { 
    //      }

    //      public final<R> Flowable<R> replay(final Function<? super Flowable<T>, ? extends Publisher<R>> selector, final int bufferSize, final Scheduler scheduler)
    //      { 
    //      }

    //      public final<R> Flowable<R> replay(Function<? super Flowable<T>, ? extends Publisher<R>> selector, long time, TimeUnit unit) { 
    //      }

    //      public final<R> Flowable<R> replay(Function<? super Flowable<T>, ? extends Publisher<R>> selector, final long time, final TimeUnit unit, final Scheduler scheduler)
    //      { 
    //      }

    //      public final<R> Flowable<R> replay(final Function<? super Flowable<T>, ? extends Publisher<R>> selector, final Scheduler scheduler)
    //      { 
    //      }

    //      public final ConnectableFlowable<T> replay(final int bufferSize)
    //      { 
    //      }

    //      public final ConnectableFlowable<T> replay(int bufferSize, long time, TimeUnit unit) { 
    //      }

    //      public final ConnectableFlowable<T> replay(final int bufferSize, final long time, final TimeUnit unit, final Scheduler scheduler)
    //      { 
    //      }

    //      public final ConnectableFlowable<T> replay(final int bufferSize, final Scheduler scheduler)
    //      { 
    //      }

    //      public final ConnectableFlowable<T> replay(long time, TimeUnit unit) { 
    //      }

    //      public final ConnectableFlowable<T> replay(final long time, final TimeUnit unit, final Scheduler scheduler)
    //      { 
    //      }

    //      public final ConnectableFlowable<T> replay(final Scheduler scheduler)
    //      { 
    //      }

    //      public final Flowable<T> retry() { 
    //      }

    //      public final Flowable<T> retry(BiPredicate<? super Integer, ? super Throwable> predicate) { 
    //      }

    //      public final Flowable<T> retry(long count) { 
    //      }

    //      public final Flowable<T> retry(long times, Predicate<? super Throwable> predicate) 
    //{ 
    //      }

    //      public final Flowable<T> retry(Predicate<? super Throwable> predicate) { 
    //      }

    //      public final Flowable<T> retryUntil(final BooleanSupplier stop)
    //      { 
    //      }

    //      public final Flowable<T> retryWhen(
    //          final Function<? super Flowable<Throwable>, ? extends Publisher<?>> handler)
    //      { 
    //      }

    //      public final void safeSubscribe(Subscriber<? super T> s)
    //      { 
    //      }

    //      public final Flowable<T> sample(long period, TimeUnit unit) { 
    //      }

    //      public final Flowable<T> sample(long period, TimeUnit unit, boolean emitLast) { 
    //      }

    //      public final Flowable<T> sample(long period, TimeUnit unit, Scheduler scheduler) { 
    //      }

    //      public final Flowable<T> sample(long period, TimeUnit unit, Scheduler scheduler, boolean emitLast) { 
    //      }

    //      public final<U> Flowable<T> sample(Publisher<U> sampler) 
    //{ 
    //      }

    //      public final<U> Flowable<T> sample(Publisher<U> sampler, boolean emitLast) { 
    //      }

    //      public final Flowable<T> scan(BiFunction<T, T, T> accumulator) { 
    //      }

    //      public final<R> Flowable<R> scan(final R initialValue, BiFunction<R, ? super T, R> accumulator)
    //      { 
    //      }

    //      public final<R> Flowable<R> scanWith(Callable<R> seedSupplier, BiFunction<R, ? super T, R> accumulator) 
    //{ 
    //      }

    //      public final Flowable<T> serialize() 
    //{ 
    //      }

    //      public final Flowable<T> share() { 
    //      }

    //      public final Maybe<T> singleElement() { 
    //      }

    //      public final Single<T> single(T defaultItem) { 
    //      }

    //      public final Single<T> singleOrError() { 
    //      }

    //      public final Flowable<T> skip(long count) { 
    //      }

    //      public final Flowable<T> skip(long time, TimeUnit unit) { 
    //      }

    //      public final Flowable<T> skip(long time, TimeUnit unit, Scheduler scheduler) { 
    //      }

    //      public final Flowable<T> skipLast(int count) { 
    //      }

    //      public final Flowable<T> skipLast(long time, TimeUnit unit) { 
    //      }

    //      public final Flowable<T> skipLast(long time, TimeUnit unit, boolean delayError) { 
    //      }

    //      public final Flowable<T> skipLast(long time, TimeUnit unit, Scheduler scheduler) { 
    //      }

    //      public final Flowable<T> skipLast(long time, TimeUnit unit, Scheduler scheduler, boolean delayError) { 
    //      }

    //      public final Flowable<T> skipLast(long time, TimeUnit unit, Scheduler scheduler, boolean delayError, int bufferSize) { 
    //      }

    //      public final<U> Flowable<T> skipUntil(Publisher<U> other) { 
    //      }

    //      public final Flowable<T> skipWhile(Predicate<? super T> predicate) { 
    //      }

    //      public final Flowable<T> sorted() { 
    //      }

    //      public final Flowable<T> sorted(Comparator<? super T> sortFunction) { 
    //      }

    //      public final Flowable<T> startWith(Iterable<? extends T> items) { 
    //      }

    //      public final Flowable<T> startWith(Publisher<? extends T> other) { 
    //      }

    //      public final Flowable<T> startWith(T value) { 
    //      }

    //      public final Flowable<T> startWithArray(T...items) {
    //      }


    //      protected abstract void subscribeActual(Subscriber<? super T> s);

    //      public final<E extends Subscriber<? super T>> E subscribeWith(E subscriber)
    //      { 
    //      }

    //      public final Flowable<T> subscribeOn(@NonNull Scheduler scheduler)
    //      { 
    //      }

    //      public final Flowable<T> subscribeOn(@NonNull Scheduler scheduler, boolean requestOn)
    //      { 
    //      }

    //      public final Flowable<T> switchIfEmpty(Publisher<? extends T> other) { 
    //      }

    //      public final<R> Flowable<R> switchMap(Function<? super T, ? extends Publisher<? extends R>> mapper) { 
    //      }

    //      public final<R> Flowable<R> switchMap(Function<? super T, ? extends Publisher<? extends R>> mapper, int bufferSize) { 
    //      }

    //      public final Completable switchMapCompletable(@NonNull Function<? super T, ? extends CompletableSource> mapper)
    //      { 
    //      }

    //      public final Completable switchMapCompletableDelayError(@NonNull Function<? super T, ? extends CompletableSource> mapper)
    //      { 
    //      }

    //      public final<R> Flowable<R> switchMapDelayError(Function<? super T, ? extends Publisher<? extends R>> mapper) { 
    //      }

    //      public final<R> Flowable<R> switchMapDelayError(Function<? super T, ? extends Publisher<? extends R>> mapper, int bufferSize) { 
    //      }

    //<R> Flowable<R> switchMap0(Function<? super T, ? extends Publisher<? extends R>> mapper, int bufferSize, boolean delayError)
    //      { 
    //          return RxJavaPlugins.onAssembly(new FlowableSwitchMap<T, R>(this, mapper, bufferSize, delayError));
    //      }

    //      public final<R> Flowable<R> switchMapMaybe(@NonNull Function<? super T, ? extends MaybeSource<? extends R>> mapper)
    //      { 
    //      }

    //      public final<R> Flowable<R> switchMapMaybeDelayError(@NonNull Function<? super T, ? extends MaybeSource<? extends R>> mapper)
    //      {
    //      }

    //      public final<R> Flowable<R> switchMapSingle(@NonNull Function<? super T, ? extends SingleSource<? extends R>> mapper)
    //      { 
    //      }

    //      public final<R> Flowable<R> switchMapSingleDelayError(@NonNull Function<? super T, ? extends SingleSource<? extends R>> mapper)
    //      {
    //      }

    //      public final Flowable<T> take(long count) { 
    //      }

    //      public final Flowable<T> take(long time, TimeUnit unit) { 
    //      }

    //      public final Flowable<T> take(long time, TimeUnit unit, Scheduler scheduler) { 
    //      }

    //      public final Flowable<T> takeLast(int count) { 
    //      }

    //      public final Flowable<T> takeLast(long count, long time, TimeUnit unit) { 
    //      }

    //      public final Flowable<T> takeLast(long count, long time, TimeUnit unit, Scheduler scheduler) { 
    //      }

    //      public final Flowable<T> takeLast(long count, long time, TimeUnit unit, Scheduler scheduler, boolean delayError, int bufferSize) { 
    //      }

    //      public final Flowable<T> takeLast(long time, TimeUnit unit) { 
    //      }

    //      public final Flowable<T> takeLast(long time, TimeUnit unit, boolean delayError) { 
    //      }

    //      public final Flowable<T> takeLast(long time, TimeUnit unit, Scheduler scheduler) {
    //      }

    //      public final Flowable<T> takeLast(long time, TimeUnit unit, Scheduler scheduler, boolean delayError) { 
    //      }

    //      public final Flowable<T> takeLast(long time, TimeUnit unit, Scheduler scheduler, boolean delayError, int bufferSize) { 
    //      }

    //      public final Flowable<T> takeUntil(Predicate<? super T> stopPredicate) {
    //      }

    //      public final<U> Flowable<T> takeUntil(Publisher<U> other) { 
    //      }

    //      public final Flowable<T> takeWhile(Predicate<? super T> predicate) { 
    //      }

    //      public final Flowable<T> throttleFirst(long windowDuration, TimeUnit unit) {
    //      }

    //      public final Flowable<T> throttleFirst(long skipDuration, TimeUnit unit, Scheduler scheduler) { 
    //      }

    //      public final Flowable<T> throttleLast(long intervalDuration, TimeUnit unit) { 
    //      }

    //      public final Flowable<T> throttleLast(long intervalDuration, TimeUnit unit, Scheduler scheduler) { 
    //      }

    //      public final Flowable<T> throttleLatest(long timeout, TimeUnit unit) { 
    //      }

    //      public final Flowable<T> throttleLatest(long timeout, TimeUnit unit, boolean emitLast) { 
    //      }

    //      public final Flowable<T> throttleLatest(long timeout, TimeUnit unit, Scheduler scheduler) { 
    //      }

    //      public final Flowable<T> throttleLatest(long timeout, TimeUnit unit, Scheduler scheduler, boolean emitLast) {
    //      }

    //      public final Flowable<T> throttleWithTimeout(long timeout, TimeUnit unit) { 
    //      }

    //      public final Flowable<T> throttleWithTimeout(long timeout, TimeUnit unit, Scheduler scheduler) { 
    //      }

    //      public final Flowable<Timed<T>> timeInterval() {
    //      }

    //      public final Flowable<Timed<T>> timeInterval(Scheduler scheduler) { 
    //      }

    //      public final Flowable<Timed<T>> timeInterval(TimeUnit unit) {
    //      }

    //      public final Flowable<Timed<T>> timeInterval(TimeUnit unit, Scheduler scheduler) { 
    //      }

    //      public final<V> Flowable<T> timeout(Function<? super T, ? extends Publisher<V>> itemTimeoutIndicator) { 
    //      }

    //      public final<V> Flowable<T> timeout(Function<? super T, ? extends Publisher<V>> itemTimeoutIndicator, Flowable<? extends T> other) {
    //      }

    //      public final Flowable<T> timeout(long timeout, TimeUnit timeUnit) {
    //      }

    //      public final Flowable<T> timeout(long timeout, TimeUnit timeUnit, Publisher<? extends T> other) { 
    //      }

    //      public final Flowable<T> timeout(long timeout, TimeUnit timeUnit, Scheduler scheduler, Publisher<? extends T> other) { 
    //      }

    //      public final Flowable<T> timeout(long timeout, TimeUnit timeUnit, Scheduler scheduler) {
    //      }

    //      public final<U, V> Flowable<T> timeout(Publisher<U> firstTimeoutIndicator,
    //          Function<? super T, ? extends Publisher<V>> itemTimeoutIndicator) { 
    //      }

    //      public final<U, V> Flowable<T> timeout(
    //          Publisher<U> firstTimeoutIndicator,
    //          Function<? super T, ? extends Publisher<V>> itemTimeoutIndicator,
    //                  Publisher<? extends T> other) 
    //{
    //      }

    //      private Flowable<T> timeout0(long timeout, TimeUnit timeUnit, Publisher<? extends T> other,
    //              Scheduler scheduler)
    //      { 
    //      }

    //      private <U, V> Flowable<T> timeout0(
    //              Publisher<U> firstTimeoutIndicator,
    //              Function<? super T, ? extends Publisher<V>> itemTimeoutIndicator,
    //                      Publisher<? extends T> other)
    //      { 
    //      }

    //      public final Flowable<Timed<T>> timestamp() { 
    //      }

    //      public final Flowable<Timed<T>> timestamp(Scheduler scheduler) {
    //      }

    //      public final Flowable<Timed<T>> timestamp(TimeUnit unit) { 
    //      }

    //      public final Flowable<Timed<T>> timestamp(final TimeUnit unit, final Scheduler scheduler)
    //      { 
    //      }

    //      public final<R> R to(Function<? super Flowable<T>, R> converter)
    //      { 
    //      }

    //      public final Single<List<T>> toList() { 
    //      }

    //      public final Single<List<T>> toList(final int capacityHint)
    //      { 
    //      }

    //      public final<U extends Collection<? super T>> Single<U> toList(Callable<U> collectionSupplier) { 
    //      }

    //      public final<K> Single<Map<K, T>> toMap(final Function<? super T, ? extends K> keySelector)
    //      {
    //      }

    //      public final<K, V> Single<Map<K, V>> toMap(final Function<? super T, ? extends K> keySelector, final Function<? super T, ? extends V> valueSelector)
    //      { 
    //      }

    //      public final<K, V> Single<Map<K, V>> toMap(final Function<? super T, ? extends K> keySelector,
    //          final Function<? super T, ? extends V> valueSelector,
    //          final Callable<? extends Map<K, V>> mapSupplier)
    //      { 
    //      }

    //      public final<K> Single<Map<K, Collection<T>>> toMultimap(Function<? super T, ? extends K> keySelector) 
    //{
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
    //      }

    //      public final<K, V> Single<Map<K, Collection<V>>> toMultimap(
    //          Function<? super T, ? extends K> keySelector,
    //          Function<? super T, ? extends V> valueSelector,
    //          Callable<Map<K, Collection<V>>> mapSupplier
    //          ) {
    //      }

    //      public final Observable<T> toObservable() { 
    //      }

    //      public final Single<List<T>> toSortedList() {
    //      }

    //      public final Single<List<T>> toSortedList(final Comparator<? super T> comparator)
    //      { 
    //      }

    //      public final Single<List<T>> toSortedList(final Comparator<? super T> comparator, int capacityHint)
    //      {
    //      }

    //      public final Single<List<T>> toSortedList(int capacityHint) { 
    //      }

    //      public final Flowable<T> unsubscribeOn(Scheduler scheduler) {
    //      }

    //      public final Flowable<Flowable<T>> window(long count) { 
    //      }

    //      public final Flowable<Flowable<T>> window(long count, long skip) {
    //      }

    //      public final Flowable<Flowable<T>> window(long count, long skip, int bufferSize) { 
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, long timeskip, TimeUnit unit) { 
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, long timeskip, TimeUnit unit, Scheduler scheduler) {
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, long timeskip, TimeUnit unit, Scheduler scheduler, int bufferSize) { 
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, TimeUnit unit) { 
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, TimeUnit unit,
    //          long count) {
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, TimeUnit unit,
    //          long count, boolean restart) {
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, TimeUnit unit,
    //          Scheduler scheduler) {
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, TimeUnit unit,
    //          Scheduler scheduler, long count) { 
    //      }

    //      public final Flowable<Flowable<T>> window(long timespan, TimeUnit unit,
    //          Scheduler scheduler, long count, boolean restart) { 
    //      }

    //      public final Flowable<Flowable<T>> window(
    //          long timespan, TimeUnit unit, Scheduler scheduler,
    //          long count, boolean restart, int bufferSize) {
    //      }

    //      public final<B> Flowable<Flowable<T>> window(Publisher<B> boundaryIndicator) {
    //      }

    //      public final<B> Flowable<Flowable<T>> window(Publisher<B> boundaryIndicator, int bufferSize) { 
    //      }

    //      public final<U, V> Flowable<Flowable<T>> window(
    //          Publisher<U> openingIndicator,
    //          Function<? super U, ? extends Publisher<V>> closingIndicator) { 
    //      }

    //      public final<U, V> Flowable<Flowable<T>> window(
    //          Publisher<U> openingIndicator,
    //          Function<? super U, ? extends Publisher<V>> closingIndicator, int bufferSize) { 
    //      }

    //      public final<B> Flowable<Flowable<T>> window(Callable<? extends Publisher<B>> boundaryIndicatorSupplier) {
    //      }

    //      public final<B> Flowable<Flowable<T>> window(Callable<? extends Publisher<B>> boundaryIndicatorSupplier, int bufferSize) {
    //      }

    //      public final<U, R> Flowable<R> withLatestFrom(Publisher<? extends U> other,
    //          BiFunction<? super T, ? super U, ? extends R> combiner) { 
    //      }

    //      public final<T1, T2, R> Flowable<R> withLatestFrom(Publisher<T1> source1, Publisher<T2> source2,
    //          Function3<? super T, ? super T1, ? super T2, R> combiner) {
    //      }

    //      public final<T1, T2, T3, R> Flowable<R> withLatestFrom(
    //          Publisher<T1> source1, Publisher<T2> source2,
    //          Publisher<T3> source3,
    //          Function4<? super T, ? super T1, ? super T2, ? super T3, R> combiner) { 
    //      }

    //      public final<T1, T2, T3, T4, R> Flowable<R> withLatestFrom(
    //          Publisher<T1> source1, Publisher<T2> source2,
    //          Publisher<T3> source3, Publisher<T4> source4,
    //          Function5<? super T, ? super T1, ? super T2, ? super T3, ? super T4, R> combiner) { 
    //      }

    //      public final<R> Flowable<R> withLatestFrom(Publisher<?>[] others, Function<? super Object[], R> combiner) { 
    //      }

    //      public final<R> Flowable<R> withLatestFrom(Iterable<? extends Publisher<?>> others, Function<? super Object[], R> combiner) { 
    //      }

    //      public final<U, R> Flowable<R> zipWith(Iterable<U> other, BiFunction<? super T, ? super U, ? extends R> zipper) {
    //      }

    //      public final<U, R> Flowable<R> zipWith(Publisher<? extends U> other, BiFunction<? super T, ? super U, ? extends R> zipper) { 
    //      }

    //      public final<U, R> Flowable<R> zipWith(Publisher<? extends U> other,
    //          BiFunction<? super T, ? super U, ? extends R> zipper, boolean delayError) { 
    //      }

    //      public final<U, R> Flowable<R> zipWith(Publisher<? extends U> other,
    //          BiFunction<? super T, ? super U, ? extends R> zipper, boolean delayError, int bufferSize) { 
    //      }

    //      // -------------------------------------------------------------------------
    //      // Fluent test support, super handy and reduces test preparation boilerplate
    //      // -------------------------------------------------------------------------
    //      public final TestSubscriber<T> test() { 
    //      }

    //      public final TestSubscriber<T> test(long initialRequest) {  
    //      }

    //      public final TestSubscriber<T> test(long initialRequest, boolean cancel) { 
    //      }
}
