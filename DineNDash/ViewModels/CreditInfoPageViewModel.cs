using System;
using System.Collections.Generic;
using System.Diagnostics;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace DineNDash.ViewModels
{
    public class CreditInfoPageViewModel : BindableBase, INavigationAware
    {
        public CreditInfoPageViewModel()
        {
            creditCards = new List<string>()
            {
                "MasterCard",
                "Visa",
                "Discover"
            };
        }

        List<string> creditCards;
        public List<string> CreditCards
        {
            get { return creditCards; }
            set { SetProperty(ref creditCards, value); }
        }

        private string selectedCard;
        public string SelectedCard
        {
            get { return selectedCard; }
            set { SetProperty(ref selectedCard, value); }
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

