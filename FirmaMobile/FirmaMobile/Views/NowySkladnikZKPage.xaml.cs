using FirmaMobile.ServiceReference;
using FirmaMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirmaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NowySkladnikZKPage : ContentPage
    {
        public SkladnikZKForView Item { get; set; }
        public NowySkladnikZKPage()
        {
            InitializeComponent();
            BindingContext = new NowySkladnikZKViewModel();
        }
    }
}