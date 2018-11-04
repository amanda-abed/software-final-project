using System;

using Xamarin.Forms;

namespace DineNDash.ViewModels
{
    public class CartPageViewModel : ContentPage
    {
        public CartPageViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

