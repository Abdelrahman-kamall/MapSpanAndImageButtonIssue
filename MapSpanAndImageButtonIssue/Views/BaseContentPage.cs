using MapSpanAndImageButtonIssue.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapSpanAndImageButtonIssue.Views
{
    public class BaseContentPage : ContentPage
    {
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (BindingContext is IBaseViewModel baseView)
            {
                /// refresh will be called each time we navigate to the page
                /// while initilize will be called the first time only 

                if (!baseView.IsInitialized)
                {
                    await baseView.InitializeAsync();
                    baseView.IsInitialized = true;
                }
                await baseView.RefreshAsync();

            }
        }
    }
}
