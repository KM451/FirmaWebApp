using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ZleceniaZakupuPage : ContentPage
    {
        ZleceniaZakupuViewModel _viewModel;
        public ZleceniaZakupuPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ZleceniaZakupuViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}