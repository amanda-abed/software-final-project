using System;

using Xamarin.Forms;

namespace DineNDash.ViewModels
{
    public class FirstMenuPageViewModel : ContentPage
    {
        public FirstMenuPageViewModel()
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

