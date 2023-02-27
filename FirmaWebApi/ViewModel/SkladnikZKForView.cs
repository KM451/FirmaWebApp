using Firma.Data.Model;
using Firma.Utils.Extensions;

namespace FirmaWebApi.ViewModel
{
    public class SkladnikZKForView
    {
        public int IdSkladnika { get; set; }
        public int IdZleceniaKompletacji { get; set; }
        public string? ZlecenieKompletacjiDane { get; set; }
        public int? IdProduktu { get; set; }
        public string? ProduktDane { get; set; }
        public decimal Ilosc { get; set; }
        public bool CzyAktywny { get; set; }

        public static explicit operator SkladnikZK(SkladnikZKForView skladnikZKForView)
        {
            return new SkladnikZK().CopyPropertiesReturnExtension(skladnikZKForView);
        }
        public static explicit operator SkladnikZKForView(SkladnikZK skladnikZK)
        {
            var skladnikZKForView = new SkladnikZKForView().CopyPropertiesReturnExtension(skladnikZK);

            skladnikZKForView.ZlecenieKompletacjiDane = "Nr: " + skladnikZK.ZlecenieKompletacji.IdZleceniaKompletacji
                                              + " z dnia: " + skladnikZK.ZlecenieKompletacji?.DataWystawienia.ToString("d");

            skladnikZKForView.ProduktDane = skladnikZK.Produkt?.Kod + ", " + skladnikZK.Produkt?.Nazwa;

            return skladnikZKForView;
        }
    }
}
