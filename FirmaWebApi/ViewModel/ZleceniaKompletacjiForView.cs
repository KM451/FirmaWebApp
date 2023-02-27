using Firma.Data.Model;
using Firma.Utils.Extensions;

namespace FirmaWebApi.ViewModel
{
    public class ZleceniaKompletacjiForView
    {
        public int IdZleceniaKompletacji { get; set; }
        public int IdKontrahenta { get; set; }
        public string? KontrahentDane { get; set; }
        public DateTime DataWystawienia { get; set; }
        public DateTime OczekiwanaDataRealizacji { get; set; }
        public DateTime? PotwierdzonaDataRealizacji { get; set; }
        public int IdProduktu { get; set; }
        public string? ProduktDane { get; set; }
        public decimal Ilosc { get; set; }
        public int? IdMontera { get; set; }
        public string? MonterNazwa { get; set; }
        public int? Priorytet { get; set; }
        public string Status { get; set; }
        public bool CzyAktywne { get; set; }
        public int? CzasZlecenia { get; set; }

        public static explicit operator ZlecenieKompletacji(ZleceniaKompletacjiForView zleceniaKompletacjiForView)
        {
            return new ZlecenieKompletacji().CopyPropertiesReturnExtension(zleceniaKompletacjiForView);
        }
        public static explicit operator ZleceniaKompletacjiForView(ZlecenieKompletacji zlecenieKompletacji)
        {
            var zleceniaKompletacjiForView = new ZleceniaKompletacjiForView().CopyPropertiesReturnExtension(zlecenieKompletacji);

            zleceniaKompletacjiForView.KontrahentDane = zlecenieKompletacji.Kontrahent?.Nazwa + ", NIP: " + zlecenieKompletacji.Kontrahent?.Nip;
            zleceniaKompletacjiForView.ProduktDane = zlecenieKompletacji.Produkt?.Kod + ", " + zlecenieKompletacji.Produkt?.Nazwa;
            zleceniaKompletacjiForView.MonterNazwa = zlecenieKompletacji.Monter?.Nazwa;
            return zleceniaKompletacjiForView;
        }
    }
}
