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

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedTo)}");
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedFrom)}");
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedTo)}");
        }
    }
}

