using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PozycjeZZPage : ContentPage
    {
        PozycjeZZViewModel _viewModel;
        public PozycjeZZPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PozycjeZZViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}