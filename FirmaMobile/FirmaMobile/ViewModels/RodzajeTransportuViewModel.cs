using FirmaMobile.Models;
using FirmaMobile.Views;
using System;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    public class RodzajeTransportuViewModel : AItemsViewModel<RodzajeTransportuForView>
    {
        public RodzajeTransportuViewModel(): base("Rodzaje transportu"){}
        public async override void GoToAddPage() => await Shell.Current.GoToAsync(nameof(NowyRodzajTransportuPage));

        public override void GoToDetailsPage(RodzajeTransportuForView item)
        {
            throw new NotImplementedException();
        }
    }
}
