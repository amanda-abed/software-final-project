using System.Diagnostics;
using Prism.Mvvm;

namespace DineNDash.ViewModels
{
    public class DineNDashHomePageViewModel : BindableBase
    {
        public DineNDashHomePageViewModel()
        {
            Debug.WriteLine($"**** {this.GetType().Name}: ctor");
        }
    }
}