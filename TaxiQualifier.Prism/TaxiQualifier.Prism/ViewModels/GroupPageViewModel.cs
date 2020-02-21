using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TaxiQualifier.Prism.ViewModels
{
    public class GroupPageViewModel : ViewModelBase
    {
        public GroupPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Admin my user group";
        }
    }
}
