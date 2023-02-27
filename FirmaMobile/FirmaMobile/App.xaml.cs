using FirmaMobile.Services;
using Xamarin.Forms;

namespace FirmaMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            DependencyService.Register<KontrahenciDataStore>();
            DependencyService.Register<MonterzyDataStore>();
            DependencyService.Register<RodzajeTransportuDataStore>();
            DependencyService.Register<SposobyDostawyDataStore>();
            DependencyService.Register<TypyTransakcjiDataStore>();
            DependencyService.Register<SposobyPlatnosciDataStore>();
            DependencyService.Register<TypyCenDataStore>();
            DependencyService.Register<TypyProduktowDataStore>();
            DependencyService.Register<CenyDataStore>();
            DependencyService.Register<PozycjeZZDataStore>();
            DependencyService.Register<ProduktyDataStore>();
            DependencyService.Register<ProduktyUboczneZKDataStore>();
            DependencyService.Register<SkladnikZKDataStore>();
            DependencyService.Register<ZlecenieKompletacjiDataStore>();
            DependencyService.Register<ZlecenieZakupuDataStore>();
            
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
