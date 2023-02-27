using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RodzajeTransportuPage : ContentPage
    {
        RodzajeTransportuViewModel _viewModel;
        public RodzajeTransportuPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new RodzajeTransportuViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}