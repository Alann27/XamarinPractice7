using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPractice7.ViewModels;
using XamarinPractice7.Views;

namespace XamarinPractice7
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializar = null) : base(initializar) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync($"{NavigationConstants.NavigationPage}/{NavigationConstants.HomePage}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>(NavigationConstants.NavigationPage);
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>(NavigationConstants.HomePage);
        }
    }
}
