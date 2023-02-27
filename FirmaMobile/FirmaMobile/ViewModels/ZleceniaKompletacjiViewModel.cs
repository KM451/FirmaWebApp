using FirmaMobile.ServiceReference;
using FirmaMobile.Views;
using System;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    public class ZleceniaKompletacjiViewModel : AItemsViewModel<ZleceniaKompletacjiForView>
    {
        public ZleceniaKompletacjiViewModel() : base("Zlecenia kompletacji")
        {
        }
        public override async void GoToAddPage() => await Shell.Current.GoToAsync(nameof(NoweZlecenieKompletacjiPage));

        public override void GoToDetailsPage(ZleceniaKompletacjiForView item)
        {
            throw new NotImplementedException();
        }
    }
}
