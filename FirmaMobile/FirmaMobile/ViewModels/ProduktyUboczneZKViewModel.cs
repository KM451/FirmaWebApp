using FirmaMobile.ServiceReference;
using FirmaMobile.Views;
using System;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    public class 
        ProduktyUboczneZKViewModel : AItemsViewModel<ProduktyUboczneZKForView>
    {
        public ProduktyUboczneZKViewModel() : base("Produkty uboczne zlecenia kompletacji")
        { }
        public override async void GoToAddPage() => await Shell.Current.GoToAsync(nameof(NowyProduktUbocznyZKPage)); 
        public override void GoToDetailsPage(ProduktyUboczneZKForView item)
        {
            throw new System.NotImplementedException();
        }
    }
}
