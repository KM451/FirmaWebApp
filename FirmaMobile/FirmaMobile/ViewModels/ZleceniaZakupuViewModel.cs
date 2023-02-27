using FirmaMobile.ServiceReference;
using FirmaMobile.Views;
using System;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    public class ZleceniaZakupuViewModel : AItemsViewModel<ZleceniaZakupuForView>
    {
        public ZleceniaZakupuViewModel() : base("Zlecenia zakupu")
        {
        }
        public override async void GoToAddPage() => await Shell.Current.GoToAsync(nameof(NoweZlecenieZakupuPage));

        public override void GoToDetailsPage(ZleceniaZakupuForView item)
        {
            throw new NotImplementedException();
        }
    }
}
