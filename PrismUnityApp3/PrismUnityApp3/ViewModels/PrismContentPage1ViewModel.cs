using Prism.Commands;
using Prism.Mvvm;
using PrismUnityApp3.Constants;
using PrismUnityApp3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Prism.Navigation;
using Xamarin.Forms;

namespace PrismUnityApp3.ViewModels
{
    public class PrismContentPage1ViewModel : MainPageViewModel
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public PrismContentPage1ViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            ListElements = new ObservableCollection<string> {"b"};
            Title = "ggg";
        }
        private ObservableCollection<string> _listElements;
        public ObservableCollection<string> ListElements
        {
            get { return _listElements; }
            set
            {
                SetProperty(ref _listElements, value);

            }
        }
        private DelegateCommand _command;
        public DelegateCommand Command => _command = new DelegateCommand(Commandt);


        private async void Commandt()
        {
            await NavigationService.PushPopupPageAsync("Popup");
        }

    }
}
