using FirmaMobile.ServiceReference;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoweZlecenieZakupuPage : ContentPage
    {
        public ZleceniaZakupuForView Item { get; set; }
        public NoweZlecenieZakupuPage()
        {
            InitializeComponent();
            BindingContext = new NoweZlecenieZakupuViewModel();
        }
    }
}