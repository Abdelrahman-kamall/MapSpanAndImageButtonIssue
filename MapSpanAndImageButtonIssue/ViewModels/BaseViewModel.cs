using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapSpanAndImageButtonIssue.ViewModels
{
    public class BaseViewModel : ObservableObject, IBaseViewModel
    {
        private readonly SemaphoreSlim _isBusyLock = new(1, 1);
        private bool _disposedValue;

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }
        private bool _isInitialized;
        public bool IsInitialized
        {
            get => _isInitialized;
            set => SetProperty(ref _isInitialized, value);
        }

        public BaseViewModel()
        {
            _isInitialized = false;
            _isBusy = false;
            _disposedValue = false;
        }

        public virtual void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            return;
        }

        public virtual Task InitializeAsync()
        {
            return Task.CompletedTask;
        }

        public virtual Task RefreshAsync()
        {
            return Task.CompletedTask;
        }

        public async Task IsBusyFor(Func<Task> unitOfWork)
        {
            await _isBusyLock.WaitAsync();

            try
            {
                IsBusy = true;
                await unitOfWork();
            }
            finally
            {
                IsBusy = false;
                _isBusyLock.Release();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                //handle managed resources here
                if (disposing)
                {
                    _isBusyLock?.Dispose();
                }

                //handle managed resources here


                _disposedValue = true;
            }
        }

        // Do not make this method virtual.
        // A derived class should not be able to override this method.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
