using FirmaMobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PozycjaZZDetailPage : ContentPage
    {
        public PozycjaZZDetailPage()
        {
            InitializeComponent();
            BindingContext = new DetailPozycjaZZViewModel("Dane szczegółowe pozycji zlecenia zakupu");
        }
    }
}