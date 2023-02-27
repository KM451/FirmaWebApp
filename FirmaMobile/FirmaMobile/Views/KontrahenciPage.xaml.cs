using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KontrahenciPage : ContentPage
    {
        KontrahenciViewModel _viewModel;
        public KontrahenciPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new KontrahenciViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

    }
}