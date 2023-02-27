using FirmaMobile.ServiceReference;
using FirmaMobile.Views;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    public class PozycjeZZViewModel : AItemsViewModel<PozycjeZZForView>
    {
        public PozycjeZZViewModel():base("Pozycje zlecenia zakupu")
        {
        }
        public override async void GoToAddPage() => await Shell.Current.GoToAsync(nameof(NowaPozycjaZZPage));

        public async override void GoToDetailsPage(PozycjeZZForView item) => await
            Shell.Current.GoToAsync($"{nameof(PozycjaZZDetailPage)}?{nameof(DetailPozycjaZZViewModel.IdPozycjiZZ)}={item.IdPozycjiZleceniaZakupu}");
    }
}
