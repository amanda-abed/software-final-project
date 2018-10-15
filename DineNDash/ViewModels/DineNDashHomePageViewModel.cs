using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using Plugin.ExternalMaps;
using Prism.Commands;
using Prism.Mvvm;

namespace DineNDash.ViewModels
{
    public class DineNDashHomePageViewModel : BindableBase
    {
        public DelegateCommand GoToMapCommand { get; set; }
        public DelegateCommand searchActivated { get; set; }

        private string enter_restaurant;
        public string EnterRestaurant
        {
            get { return enter_restaurant; }
            set { SetProperty(ref enter_restaurant, value); }
        }

        List<string> restaurants = new List<string>
        {
            "In-N-Out Burger"
        };

        public DineNDashHomePageViewModel()
        {
            Debug.WriteLine($"**** {this.GetType().Name}: ctor");

            GoToMapCommand = new DelegateCommand(GoToMap);
            searchActivated = new DelegateCommand(GoToSearch);
        }

        private void GoToSearch()
        {


//            restaurants.Where(r => r.Contains());
        }

        private void GoToMap()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(GoToMap)}");
            CrossExternalMaps.Current.NavigateTo("In-N-Out Burger", "583 Grand Ave", "San Marcos", "CA", "92078", "USA", "USA");
        }

    }


}