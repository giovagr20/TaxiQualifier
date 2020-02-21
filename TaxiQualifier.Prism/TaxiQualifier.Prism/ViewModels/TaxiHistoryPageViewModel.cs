using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TaxiQualifier.Prism.ViewModels
{
    public class TaxiHistoryPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public TaxiHistoryPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Taxi History";
        }
    }
}
