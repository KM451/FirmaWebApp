using FirmaMobile.ServiceReference;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoweZlecenieKompletacjiPage : ContentPage
    {
        public ZleceniaKompletacjiForView Item { get; set; }
        public NoweZlecenieKompletacjiPage()
        {
            InitializeComponent();
            BindingContext = new NoweZlecenieKompletacjiViewModel();
        }
    }
}