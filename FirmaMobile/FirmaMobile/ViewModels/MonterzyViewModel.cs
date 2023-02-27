using FirmaMobile.Models;
using FirmaMobile.Views;
using System;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    public class MonterzyViewModel : AItemsViewModel<MonterzyForView>
    {
        public MonterzyViewModel(): base("Monterzy")
        {
        }
        public override async void GoToAddPage() => await Shell.Current.GoToAsync(nameof(NowyMonterPage));

        public override void GoToDetailsPage(MonterzyForView item)
        {
            throw new NotImplementedException();
        }
    }
}
