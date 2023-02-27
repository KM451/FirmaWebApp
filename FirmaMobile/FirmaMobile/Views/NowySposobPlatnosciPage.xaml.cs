using FirmaMobile.Models;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowySposobPlatnosciPage : ContentPage
    {
        public SposobyPlatnosciForView Item { get; set; }

        public NowySposobPlatnosciPage()
        {
            InitializeComponent();
            BindingContext = new NowySposobPlatnosciViewModel();
        }
    }
}