using Firma.Data.Model;
using Firma.Utils.Extensions;

namespace FirmaWebApi.ViewModel
{
    public class KontrahenciForView
    {
        public int IdKontrahenta { get; set; }
        public string Akronim { get; set; }
        public string Nazwa { get; set; }
        public string Nip { get; set; }
        public int IdSposobuPlatnosci { get; set; }
        public string SposobPlatnosciNazwa { get; set; }

        public static explicit operator Kontrahent(KontrahenciForView kontrahenciForView)
        {
            return new Kontrahent().CopyPropertiesReturnExtension(kontrahenciForView);
        }
        public static explicit operator KontrahenciForView(Kontrahent kontrahent)
        {
            var kontrahenciForView = new KontrahenciForView().CopyPropertiesReturnExtension(kontrahent);
            kontrahenciForView.SposobPlatnosciNazwa = kontrahent.SposobPlatnosci?.Nazwa;
            return kontrahenciForView;
        }
    }
}
