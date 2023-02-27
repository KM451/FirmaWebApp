using Firma.Data.Model;
using Firma.Utils.Extensions;

namespace FirmaWebApi.ViewModel
{
    public class CenyForView
    {
        public int IdCeny { get; set; }
        public int IdProduktu { get; set; }
        public string? ProduktDane { get; set; }
        public int IdTypuCeny { get; set; }
        public string? TypCenyNazwa { get; set; }
        public decimal Wartosc { get; set; }
        public string Waluta { get; set; }
        public bool CzyAktywna { get; set; }

        public static explicit operator Cena(CenyForView cenyForView)
        {
            return new Cena().CopyPropertiesReturnExtension(cenyForView);
        }
        public static explicit operator CenyForView(Cena cena)
        {
            var cenyForView = new CenyForView().CopyPropertiesReturnExtension(cena);
            cenyForView.ProduktDane = cena.Produkt?.Kod + ", " + cena.Produkt?.Nazwa;
            cenyForView.TypCenyNazwa = cena.TypCeny?.Typ;
            return cenyForView;
        }
    }
}
