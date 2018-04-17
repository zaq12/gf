using PrismUnityApp3.ViewModels;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using PrismUnityApp3.ViewModels;

namespace PrismUnityApp3.Views
{
    public partial class Popup : PopupPage
    {
        public Popup()
        {
            InitializeComponent();
            AnnounceBindingContext();
        }
        public async void OnItemTapped(object sender, ItemTappedEventArgs args)
        {
            ((PopupViewModel)this.BindingContext).GoToSelectedItemCommand.Execute(args.Item);
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            AnnounceBindingContext();
        }

        private void AnnounceBindingContext()
        {
            System.Diagnostics.Debug.WriteLine(GetType().Name);
            System.Diagnostics.Debug.WriteLine($"BindingContext: {BindingContext?.GetType()?.Name}");
        }
    }
}
