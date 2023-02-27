using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CenyPage : ContentPage
    {
        CenyViewModel _viewModel;
        public CenyPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new CenyViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}