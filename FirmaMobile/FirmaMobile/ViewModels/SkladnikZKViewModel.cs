using FirmaMobile.ServiceReference;
using FirmaMobile.Views;
using System;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    internal class SkladnikZKViewModel : AItemsViewModel<SkladnikZKForView>
    {
        public SkladnikZKViewModel() : base("Składniki zlecenia kompletacji")
        {
        }
        public override async void GoToAddPage() => await Shell.Current.GoToAsync(nameof(NowySkladnikZKPage));

        public override void GoToDetailsPage(SkladnikZKForView item)
        {
            throw new NotImplementedException();
        }
    }
}
