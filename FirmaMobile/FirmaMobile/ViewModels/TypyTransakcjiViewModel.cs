using FirmaMobile.Models;
using FirmaMobile.Views;
using System;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    public class TypyTransakcjiViewModel : AItemsViewModel<TypyTransakcjiForView>
    {
        public TypyTransakcjiViewModel(): base("Typy transakcji"){}
        public async override void GoToAddPage() => await Shell.Current.GoToAsync(nameof(NowyTypTransakcjiPage)); 
        public override void GoToDetailsPage(TypyTransakcjiForView item)
        {
            throw new NotImplementedException();
        }
    }
}
