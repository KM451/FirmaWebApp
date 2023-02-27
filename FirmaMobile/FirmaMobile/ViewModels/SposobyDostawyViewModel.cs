using FirmaMobile.Models;
using FirmaMobile.Views;
using System;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    public class SposobyDostawyViewModel : AItemsViewModel<SposobyDostawyForView>
    {
        public SposobyDostawyViewModel(): base("Sposoby dostawy"){}
        public async override void GoToAddPage() => await Shell.Current.GoToAsync(nameof(NowySposobDostawyPage)); 
        public override void GoToDetailsPage(SposobyDostawyForView item)
        {
            throw new NotImplementedException();
        }
    }
}
