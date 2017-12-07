﻿using Prism.Unity;
using PrismUnityApp3.Views;
using Xamarin.Forms;

namespace PrismUnityApp3
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<PrismContentPage1>();

            Container.RegisterTypeForNavigation<Popup>();
            Container.RegisterTypeForNavigation<PrismContentPage2>();
        }
    }
}
dd