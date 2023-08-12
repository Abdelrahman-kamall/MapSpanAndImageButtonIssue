using CommunityToolkit.Mvvm.Input;
using MapSpanAndImageButtonIssue.Services.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MapSpanAndImageButtonIssue.ViewModels
{
    public class ButtonsViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public ICommand ButtonCommand { get; }
        public ICommand ImageButtonCommand { get; }
        public ButtonsViewModel(INavigationService navigationService) 
        {
            _navigationService = navigationService;

            ButtonCommand = new AsyncRelayCommand(ButtonGoToMap);
            ImageButtonCommand = new AsyncRelayCommand(ImageButtonGoToMap);
        }

        private async Task ButtonGoToMap()
        {
            await _navigationService.NavigateToAsync("//map");
        }

        private async Task ImageButtonGoToMap()
        {
            await _navigationService.NavigateToAsync("//map");
        }
    }
}
