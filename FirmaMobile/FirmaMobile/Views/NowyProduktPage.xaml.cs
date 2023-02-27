using FirmaMobile.ServiceReference;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowyProduktPage : ContentPage
    {
        public ProduktyForView  Item { get; set; }
        public NowyProduktPage()
        {
            InitializeComponent();
            BindingContext = new NowyProduktViewModel("Nowy produkt");
        }
    }
}