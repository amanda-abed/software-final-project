using System;
using System.Diagnostics;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace DineNDash.ViewModels
{
    public class ChooseSeatingPageViewModel : BindableBase, INavigationAware
    {
       
        public ChooseSeatingPageViewModel()
        {
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedFrom)}");
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedTo)}");
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatingTo)}");
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}

