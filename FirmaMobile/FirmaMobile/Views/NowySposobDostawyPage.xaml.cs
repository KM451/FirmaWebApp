using FirmaMobile.Models;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowySposobDostawyPage : ContentPage
    {
        public SposobyDostawyForView Item { get; set; }

        public NowySposobDostawyPage()
        {
            InitializeComponent();
            BindingContext = new NowySposobDostawyViewModel();
        }
    }
}