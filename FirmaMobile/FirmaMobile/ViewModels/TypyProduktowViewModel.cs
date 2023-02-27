using FirmaMobile.Models;
using FirmaMobile.Views;
using System;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    public class TypyProduktowViewModel : AItemsViewModel<TypyProduktowForView>
    {
        public TypyProduktowViewModel() : base("Typy produktów") { }
        public async override void GoToAddPage() => await Shell.Current.GoToAsync(nameof(NowyTypProduktuPage));

        public override void GoToDetailsPage(TypyProduktowForView item)
        {
            throw new NotImplementedException();
        }
    }
}
