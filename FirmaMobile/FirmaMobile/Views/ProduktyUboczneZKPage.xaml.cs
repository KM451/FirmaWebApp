using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProduktyUboczneZKPage : ContentPage
    {
        ProduktyUboczneZKViewModel _viewModel;
        public ProduktyUboczneZKPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ProduktyUboczneZKViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}