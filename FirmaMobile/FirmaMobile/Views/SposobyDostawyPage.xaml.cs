using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SposobyDostawyPage : ContentPage
    {
        SposobyDostawyViewModel _viewModel;
        public SposobyDostawyPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new SposobyDostawyViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}