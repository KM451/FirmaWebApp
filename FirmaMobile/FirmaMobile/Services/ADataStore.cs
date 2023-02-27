using FirmaMobile.ServiceReference;

namespace FirmaMobile.Services
{
    public  class ADataStore
    {
        protected FirmaMobileService firmaMobileService;
        public ADataStore()
        {
            firmaMobileService = new FirmaMobileService("http://localhost:5033", new System.Net.Http.HttpClient());
        }
    }
}
//FirmaMobileMauiApp.ServiceReference
//MauiService