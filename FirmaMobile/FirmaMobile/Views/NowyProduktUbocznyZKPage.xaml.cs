using FirmaMobile.ServiceReference;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowyProduktUbocznyZKPage : ContentPage
    {
        public ProduktyUboczneZKForView Item { get; set; }
        public NowyProduktUbocznyZKPage()
        {
            InitializeComponent();
            BindingContext = new NowyProduktUbocznyZKViewModel();
        }
    }
}