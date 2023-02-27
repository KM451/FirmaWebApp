using FirmaMobile.ServiceReference;
using FirmaMobile.Views;
using Xamarin.Forms;

namespace FirmaMobile.ViewModels
{
    public class CenyViewModel : AItemsViewModel<CenyForView>
    {
        public CenyViewModel():base("Ceny")
        {}
        public override async void GoToAddPage() => await Shell.Current.GoToAsync(nameof(NowaCenaPage));

        public async override void GoToDetailsPage(CenyForView item) => await
            Shell.Current.GoToAsync($"{nameof(CenyDetailPage)}?{nameof(DetailCenaViewModel.IdCeny)}={item.IdCeny}");
    }
}
