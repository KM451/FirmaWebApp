using FirmaMobile.Models;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowyTypProduktuPage : ContentPage
    {
        public TypyProduktowForView Item { get; set; }
        public NowyTypProduktuPage()
        {
            InitializeComponent();
            BindingContext = new NowyTypProduktuViewModel();
        }
    }
}