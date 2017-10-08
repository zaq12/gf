
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace PrismUnityApp3.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;


        }
        DelegateCommand _redirectCommand;
        public DelegateCommand RedirectCommand => _redirectCommand = new DelegateCommand(Redirect);


        public INavigationService _navigationService;
        public INavigationService NavigationService
        {
            get { return _navigationService; }
            set { SetProperty(ref _navigationService, value); }
        }


        private async void Redirect()
        {
            await NavigationService.NavigateAsync("PrismContentPage1");
        }



        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
