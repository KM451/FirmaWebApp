using FirmaMobile.Models;
using FirmaMobile.Views;
using System;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    public class SposobyPlatnosciViewModel : AItemsViewModel<SposobyPlatnosciForView>
    {
        public SposobyPlatnosciViewModel(): base("Sposoby płatności"){}
        public async override void GoToAddPage() => await Shell.Current.GoToAsync(nameof(NowySposobPlatnosciPage)); 
        public override void GoToDetailsPage(SposobyPlatnosciForView item)
        {
            throw new NotImplementedException();
        }
    }
}
