using System;
using System.Diagnostics;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace DineNDash.ViewModels
{
    public class CashPageViewModel : BindableBase, INavigationAware
    {
        INavigationService nav_service;
        public DelegateCommand NextPage { get; set; }

        private string secret_code;
        public string SecretCode
        {
            get { return secret_code; }
            set { SetProperty(ref secret_code, value); }
        }

        public CashPageViewModel(INavigationService navigationService)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(CashPageViewModel)}:  ctor");

            nav_service = navigationService;

            NextPage = new DelegateCommand(OnNextPage);
        }

        private async void OnNextPage()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNextPage)}");

            if(secret_code == "!8&v"){
                await nav_service.NavigateAsync("MainPage", null); //FIX!
            }
            else if(secret_code == "" || secret_code != "!8&v"){
                //THROW ERROR
                await nav_service.NavigateAsync("CashPage", null);
            }
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedFrom)}");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedTo)}");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatingTo)}");
        }
    }
}

