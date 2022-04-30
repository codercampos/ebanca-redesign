using System;
using EBancaRedesign.ViewModels;
using EBancaRedesign.Views;
using Prism;
using Prism.Ioc;
using Prism.Navigation.Xaml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace EBancaRedesign
{
    public partial class App
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }
        public App() { }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginPage, LoginViewModel>("Login");
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("https://ebancaredesign.dev/Login");
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}