using Firma.Data.Model;
using Firma.Utils.Extensions;

namespace FirmaWebApi.ViewModel
{
    public class ZleceniaZakupuForView
    {
        public int IdZleceniaZakupu { get; set; }
        public int IdKontrahenta { get; set; }
        public string? KontrahentDane { get; set; }
        public int IdTransakcji { get; set; }
        public string? TypTransakcjiNazwa { get; set; }
        public int IdSposobuDostawy { get; set; }
        public string? SposobDostawyNazwa { get; set; }
        public int IdRodzajuTransportu { get; set; }
        public string? RodzajTransportuNazwa { get; set; }
        public int IdSposobuPlatnosci { get; set; }
        public string? SposobPlatnosciNazwa { get; set; }
        public string? NrOferty { get; set; }
        public bool CzyPotwierdzone { get; set; }
        public string? NrPotwierdzenia { get; set; }
        public string Status { get; set; }
        public DateTime DataWystawienia { get; set; }
        public bool CzyAktywne { get; set; }

        public static explicit operator ZlecenieZakupu(ZleceniaZakupuForView zleceniaZakupuForView)
        {
            return new ZlecenieZakupu().CopyPropertiesReturnExtension(zleceniaZakupuForView);
        }
        public static explicit operator ZleceniaZakupuForView(ZlecenieZakupu zlecenieZakupu)
        {
            var zleceniaZakupuForView = new ZleceniaZakupuForView().CopyPropertiesReturnExtension(zlecenieZakupu);

            zleceniaZakupuForView.KontrahentDane = zlecenieZakupu.Kontrahent?.Nazwa + ", NIP: " + zlecenieZakupu.Kontrahent?.Nip;
            zleceniaZakupuForView.TypTransakcjiNazwa = zlecenieZakupu.TypTransakcji?.Nazwa;
            zleceniaZakupuForView.SposobDostawyNazwa = zlecenieZakupu.SposobDostawy?.Nazwa;
            zleceniaZakupuForView.RodzajTransportuNazwa = zlecenieZakupu.RodzajTransportu?.Nazwa;
            zleceniaZakupuForView.SposobPlatnosciNazwa = zlecenieZakupu.SposobPlatnosci?.Nazwa;

            return zleceniaZakupuForView;
        }
    }
}
