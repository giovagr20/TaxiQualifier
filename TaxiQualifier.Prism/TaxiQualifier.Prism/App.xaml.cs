using Prism;
using Prism.Ioc;
using Syncfusion.Licensing;
using Taxi.Prism.ViewModels;
using TaxiQualifier.Common.Services;
using TaxiQualifier.Prism.ViewModels;
using TaxiQualifier.Prism.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TaxiQualifier.Prism
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            SyncfusionLicenseProvider.RegisterLicense("MjExMTY0QDMxMzcyZTM0MmUzMEc1K2xKbkhrV2RmMHByRXF6YUJDQlQ3RkxLZ3hxOVlyMHY0T1RiSUFEZUk9");
            InitializeComponent();
            await NavigationService.NavigateAsync("/TaxiMasterDetailPage/NavigationPage/HomePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IGeolocatorService, GeolocatorService>();
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<TaxiMasterDetailPage, TaxiMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<TaxiHistoryPage, TaxiHistoryPageViewModel>();
            containerRegistry.RegisterForNavigation<GroupPage, GroupPageViewModel>();
            containerRegistry.RegisterForNavigation<ModifyUserPage, ModifyUserPageViewModel>();
            containerRegistry.RegisterForNavigation<ReportPage, ReportPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
        }
    }
}
