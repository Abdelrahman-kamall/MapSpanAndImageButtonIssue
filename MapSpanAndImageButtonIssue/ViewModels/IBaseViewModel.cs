using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapSpanAndImageButtonIssue.ViewModels
{
    public interface IBaseViewModel : IQueryAttributable, IDisposable
    {
        public bool IsBusy { get; }

        public bool IsInitialized { get; set; }

        public Task InitializeAsync();
        public Task RefreshAsync();

        public Task IsBusyFor(Func<Task> unitOfWork);
    }
}
