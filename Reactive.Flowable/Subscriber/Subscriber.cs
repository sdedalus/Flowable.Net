using System;

namespace Reactive.Flowable.Subscriber
{
    public abstract class Subscriber<T> : ISubscriber<T>, ISubscription, IDisposable
    {
        private ISubscription subscription;
        private bool disposedValue = false; // To detect redundant calls

        public Subscriber()
        {
        }

        public virtual void Cancel()
        {
            subscription.Cancel();
        }

        public virtual void Request(int n)
        {
            OnRequestCore(n, subscription);
        }

        public virtual void OnSubscribe(ISubscription subscription)
        {
            this.subscription = subscription;
            try
            {
                OnSubscribeCore(this, () => ((ISubscription)this).Request(1));
            }
            catch (Exception ex)
            {
                OnError(ex);
            }
        }

        protected virtual void OnSubscribeCore(ISubscription subscriber, Action continuation)
        {
            continuation();
        }

        protected virtual void OnErrorCore(Exception error) { }

        protected virtual void OnNextCore(T value, Action continuation)
        {
            continuation();
        }

        protected virtual void OnCompleteCore() { }

        protected virtual void OnRequestCore(int n, ISubscription subscription)
        {
            subscription.Request(n);
        }

        public void OnComplete()
        {
            OnCompleteCore();
        }

        public void OnError(Exception error)
        {
            try
            {
                OnErrorCore(error);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual void OnNext(T value)
        {
            if (!disposedValue)
            {
                try
                {
                    OnNextCore(value, () => ((ISubscription)this).Request(1));
                }
                catch (Exception e)
                {
                    OnError(e);
                }
            }
        }


        #region IDisposable Support

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
