using System;

using Xamarin.Forms;

namespace DineNDash.Views
{
    public class RestaurantSidePage : ContentPage
    {
        public RestaurantSidePage()
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

