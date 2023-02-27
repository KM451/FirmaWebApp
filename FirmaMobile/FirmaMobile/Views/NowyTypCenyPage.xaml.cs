using FirmaMobile.Models;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowyTypCenyPage : ContentPage
    {
        public TypyCenForView Item { get; set; }
        public NowyTypCenyPage()
        {
            InitializeComponent();
            BindingContext = new NowyTypCenyViewModel();
        }
    }
}