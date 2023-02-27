using FirmaMobile.ServiceReference;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowaCenaPage : ContentPage
    {
        public CenyForView Item { get; set; }
        public NowaCenaPage()
        {
            InitializeComponent();
            BindingContext = new NowaCenaViewModel();
        }
    }
}