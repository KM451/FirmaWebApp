using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProduktyPage : ContentPage
    {
        ProduktyViewModel _viewModel;
        public ProduktyPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ProduktyViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}