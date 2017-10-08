using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace PrismUnityApp3.ViewModels
{
    public class PopupViewModel : MainPageViewModel
    {

        public PopupViewModel(INavigationService navigationService) : base(navigationService)
        {
;
            ListElements = new ObservableCollection<string> { "b", "a", "c" };
            GoToSelectedItemCommand = new Command<string>(GoToSelectedItem);
        }

        private ObservableCollection<string> _listElements;

        public ObservableCollection<string> ListElements
        {
            get { return _listElements; }
            set { SetProperty(ref _listElements, value); }
        }

        public ICommand GoToSelectedItemCommand { get; set; }
        protected async void GoToSelectedItem(string value)
        {
            var p = new NavigationParameters();
            p.Add("contact", value);
            await NavigationService.PopupGoBackAsync(p);
            // this.Title = value;
        }
    }
}
