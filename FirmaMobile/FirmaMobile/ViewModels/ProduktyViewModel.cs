﻿using FirmaMobile.ServiceReference;
using FirmaMobile.Views;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    public class ProduktyViewModel : AItemsViewModel<ProduktyForView>
    {
        
        public ProduktyViewModel():base("Produkty")
        {
        }

        public async override void GoToAddPage() => await Shell.Current.GoToAsync(nameof(NowyProduktPage));

        public async override void GoToDetailsPage(ProduktyForView item) => await 
            Shell.Current.GoToAsync($"{nameof(ProduktDetailPage)}?{nameof(DetailProduktViewModel.IdProduktu)}={item.IdProduktu}");
    }
}