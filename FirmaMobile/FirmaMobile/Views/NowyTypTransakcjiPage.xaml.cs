using FirmaMobile.Models;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowyTypTransakcjiPage : ContentPage
    {
        public TypyTransakcjiForView Item { get; set; }
        public NowyTypTransakcjiPage()
        {
            InitializeComponent();
            BindingContext = new NowyTypTransakcjiViewModel();
        }
    }
}