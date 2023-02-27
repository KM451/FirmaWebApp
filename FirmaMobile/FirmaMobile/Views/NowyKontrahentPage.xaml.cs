using FirmaMobile.ServiceReference;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowyKontrahentPage : ContentPage
    {
        public KontrahenciForView Item { get; set; }
        public NowyKontrahentPage()
        {
            InitializeComponent();
            BindingContext = new NowyKontrahentViewModel();
        }
    }
}