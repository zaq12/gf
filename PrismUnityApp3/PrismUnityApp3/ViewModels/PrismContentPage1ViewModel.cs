using Prism.Commands;
using Prism.Mvvm;
using PrismUnityApp3.Constants;
using PrismUnityApp3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrismUnityApp3.ViewModels
{
    public class PrismContentPage1ViewModel : BindableBase
    {
        public PrismContentPage1ViewModel()
        {
            ListElements = new ObservableCollection<Resource>();

        //    _listElements = new_conts;
     //       updateUI(new_conts, false);

        }
        private ObservableCollection<Resource> _listElements;
        public ObservableCollection<Resource> ListElements
        {
            get { return _listElements; }
            set
            {
            //    ObservableCollection<Resource> new_conts = new ObservableCollection<Resource>();
           //     new_conts.Add(new Resource("aaa"));
            ///    new_conts.Add(new Resource("aaaa"));
                SetProperty(ref _listElements, new Resourcelist().resourcelist);
              //  updateUI(_listElements, false);

            }
        }
        protected async Task LoadData()
        {
            ObservableCollection<Resource> new_conts = new ObservableCollection<Resource>();
            //new_conts.Add(new Resource("aaa"));
            //Load Data Here
           // ObservableCollection<Resource> new_conts = new Resourcelist().resourcelist;

                //Refresh UI
               updateUI(new_conts, false);


        }
        protected virtual void updateUI(ObservableCollection<Resource> new_elems,bool clear)
        {


            Device.BeginInvokeOnMainThread(() =>
            {

                if (clear) ListElements.Clear();
                ListElements = new_elems;
            });



        }

    }
}
