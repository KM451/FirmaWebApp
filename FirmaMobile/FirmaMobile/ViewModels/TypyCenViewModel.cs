using FirmaMobile.Models;
using FirmaMobile.Views;
using System;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    public class TypyCenViewModel : AItemsViewModel<TypyCenForView>
    {
        public TypyCenViewModel(): base("Typy cen"){}
        public async override void GoToAddPage() => await Shell.Current.GoToAsync(nameof(NowyTypCenyPage)); 
        public override void GoToDetailsPage(TypyCenForView item)
        {
            throw new NotImplementedException();
        }
    }
}
