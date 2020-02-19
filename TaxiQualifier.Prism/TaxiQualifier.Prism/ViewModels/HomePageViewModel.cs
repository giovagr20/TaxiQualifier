using Prism.Navigation;
using TaxiQualifier.Prism.ViewModels;

namespace Taxi.Prism.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        public HomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Taxi Qualifier";
        }
    }
}
