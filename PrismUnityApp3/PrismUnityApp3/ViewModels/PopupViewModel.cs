using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PrismUnityApp3.ViewModels
{
    public class PopupViewModel : BindableBase
    {

        public PopupViewModel()
        {
;
            ListElements = new ObservableCollection<string> {"b"};

        }

        private ObservableCollection<string> _listElements;

        public ObservableCollection<string> ListElements
        {
            get { return _listElements; }
            set { SetProperty(ref _listElements, value); }
        }
    }
}
