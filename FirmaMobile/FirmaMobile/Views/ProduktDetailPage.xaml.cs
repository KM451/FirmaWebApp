using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProduktDetailPage : ContentPage
    {
        public ProduktDetailPage()
        {
            InitializeComponent();
            BindingContext = new DetailProduktViewModel("Dane szczegółowe produktu");
        }
       
    }
}