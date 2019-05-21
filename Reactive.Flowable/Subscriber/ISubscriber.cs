using System;

namespace Reactive.Flowable.Subscriber
{
    public interface ISubscriber<in T> : ISubscription, IDisposable
    {
        //
        // Summary:
        //     Notifies the observer that the provider has finished sending push-based notifications.
        void OnComplete();

        // Summary:
        //     Notifies the observer that the provider has experienced an error condition.
        //
        // Parameters:
        //   error:
        //     An object that provides additional information about the error.

        void OnError(Exception error);

        // Summary:
        //     Provides the observer with new data.
        //
        // Parameters:
        //   value:
        //     The current notification information.
        void OnNext(T value);

        void OnSubscribe(ISubscription subscription);
    }
}