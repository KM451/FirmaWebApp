using FirmaMobile.Models;
using FirmaMobile.ViewModels;
using Xamarin.Forms;

namespace FirmaMobile.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}