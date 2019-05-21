using Reactive.Flowable.Subscriber;
using System;

namespace Reactive.Flowable
{
    public interface IPublisher<out T>
    {
        IDisposable Subscribe(ISubscriber<T> subscriber);
    }
}
