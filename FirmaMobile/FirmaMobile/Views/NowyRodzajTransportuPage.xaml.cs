using FirmaMobile.Models;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowyRodzajTransportuPage : ContentPage
    {
        public RodzajeTransportuForView Item { get; set; }
        public NowyRodzajTransportuPage()
        {
            InitializeComponent();
            BindingContext = new NowyRodzajTransportuViewModel();
        }
    }
}