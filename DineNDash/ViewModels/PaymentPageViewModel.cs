using System;
using System.Collections.Generic;
using System.Diagnostics;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;
using DineNDash.Views;

namespace DineNDash.ViewModels
{
    public class PaymentPageViewModel : BindableBase, INavigationAware
    {
        INavigationService _navigationService;

        public DelegateCommand ContinueToPayment { get; set; }

        public PaymentPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            _methods = new List<string>()
            {
                "Cash",
                "Credit Card"
            };

            ContinueToPayment = new DelegateCommand(GoToPayment);
        }

        private async void GoToPayment()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(GoToPayment)}");

            if (selectedMethod == "Credit Card")
            {
                await _navigationService.NavigateAsync("CreditInfoPage", null);
            }
            else{
                await _navigationService.NavigateAsync("CashPage", null);
            }
        }

        List<string> _methods;
        public List<string> Methods
        {
            get { return _methods; }
            set { SetProperty(ref _methods, value); }
        }

        private string selectedMethod;
        public string SelectedMethod
        {
            get { return selectedMethod; }
            set { SetProperty(ref selectedMethod, value); }
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

