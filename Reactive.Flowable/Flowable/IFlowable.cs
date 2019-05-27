using System;

namespace Reactive.Flowable
{
    public interface IFlowable<out T> : IPublisher<T>
    {
    }
}