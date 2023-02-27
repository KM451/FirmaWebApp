using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MonterzyPage : ContentPage
    {
        MonterzyViewModel _viewModel;
        public MonterzyPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new MonterzyViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}