using Prism.Navigation;

namespace TaxiQualifier.Prism.ViewModels
{
    public class TaxiHistoryPageViewModel : ViewModelBase
    {
        public TaxiHistoryPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Taxi History";
        }
    }
}
