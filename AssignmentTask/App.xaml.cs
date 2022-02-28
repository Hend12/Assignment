using AssignmentTask.ViewModels;
using AssignmentTask.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace AssignmentTask
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTg3NTcxQDMxMzkyZTM0MmUzMGlRbE9YV3crT3k3SnExWnkwMzZTZzd0UEVzYmprNXZURmpWQTVJV2EwRWs9");
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }
    }
}
