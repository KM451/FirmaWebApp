using FirmaMobile.ServiceReference;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowaPozycjaZZPage : ContentPage
    {
        public PozycjeZZForView Item { get; set; }
        public NowaPozycjaZZPage()
        {
            InitializeComponent();
            BindingContext = new NowaPozycjaZZViewModel();
        }
    }
}