using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkladnikiZKPage : ContentPage
    {
        SkladnikZKViewModel _viewModel;
        public SkladnikiZKPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new SkladnikZKViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}