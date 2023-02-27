using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ZleceniaKompletacjiPage : ContentPage
    {
        ZleceniaKompletacjiViewModel _viewModel;
        public ZleceniaKompletacjiPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ZleceniaKompletacjiViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}