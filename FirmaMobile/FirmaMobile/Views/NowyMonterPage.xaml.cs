using FirmaMobile.Models;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowyMonterPage : ContentPage
    {
        public MonterzyForView Item { get; set; }
        public NowyMonterPage()
        {
            InitializeComponent();
            BindingContext = new NowyMonterViewModel();
        }
    }
}