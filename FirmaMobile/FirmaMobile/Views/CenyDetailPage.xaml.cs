using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CenyDetailPage : ContentPage
    {
        public CenyDetailPage()
        {
            InitializeComponent();
            BindingContext = new DetailCenaViewModel("Dane szczegółowe ceny");
        }
    }
}