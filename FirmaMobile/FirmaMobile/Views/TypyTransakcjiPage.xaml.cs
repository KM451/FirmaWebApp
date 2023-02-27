using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TypyTransakcjiPage : ContentPage
    {
        TypyTransakcjiViewModel _viewModel;
        public TypyTransakcjiPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new TypyTransakcjiViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}