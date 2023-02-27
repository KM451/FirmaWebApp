using Firma.Data.Model;
using Firma.Utils.Extensions;

namespace FirmaWebApi.ViewModel
{
    public class ProduktyUboczneZKForView
    {
        public int IdPrUbocznego { get; set; }
        public int IdZleceniaKompletacji { get; set; }
        public string? ZlecenieKompletacjiDane { get; set; }
        public int? IdProduktu { get; set; }
        public string? ProduktDane { get; set; }
        public decimal Ilosc { get; set; }
        public bool CzyAktywny { get; set; }

        public static explicit operator ProduktUbocznyZK(ProduktyUboczneZKForView produktyUboczneZKForView)
        {
            return new ProduktUbocznyZK().CopyPropertiesReturnExtension(produktyUboczneZKForView);
        }
        public static explicit operator ProduktyUboczneZKForView(ProduktUbocznyZK produktUbocznyZK)
        {
            var produktyUboczneZKForView = new ProduktyUboczneZKForView().CopyPropertiesReturnExtension(produktUbocznyZK);

            produktyUboczneZKForView.ZlecenieKompletacjiDane = "Nr: " + produktUbocznyZK.ZlecenieKompletacji.IdZleceniaKompletacji
                                              + " z dnia: " + produktUbocznyZK.ZlecenieKompletacji?.DataWystawienia.ToString("d");

            produktyUboczneZKForView.ProduktDane = produktUbocznyZK.Produkt?.Kod + ", " + produktUbocznyZK.Produkt?.Nazwa;

            return produktyUboczneZKForView;
        }
    }
}
