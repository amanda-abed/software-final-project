using System;

using Xamarin.Forms;

namespace DineNDash.Views
{
    public class FirstMenuPage : ContentPage
    {
        public FirstMenuPage()
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

