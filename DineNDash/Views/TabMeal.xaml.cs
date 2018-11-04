using System;
using System.Collections.Generic;
using System.Diagnostics;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace DineNDash.Views
{
    public partial class TabMeal : ContentPage
    {
        INavigationService nav_service;
        public DelegateCommand ButtonClicked { get; set; }
        public TabMeal(INavigationService navigationService)
        {
            InitializeComponent();
            nav_service = navigationService;
            ButtonClicked = new DelegateCommand(GoToCart);
        }

        private async void GoToCart()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(GoToCart)}");

            await nav_service.NavigateAsync("CartPage", null);
        }
    }
}
