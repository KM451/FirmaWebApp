using Firma.Data.Model;
using Firma.Utils.Extensions;

namespace FirmaWebApi.ViewModel
{
    public class ProduktyForView
    {
        public int IdProduktu { get; set; }
        public string Kod { get; set; }
        public string Nazwa { get; set; }
        public string? DodatkowaNazwa { get; set; }
        public string JednostkaMiary { get; set; }
        public string? Symbol { get; set; }
        public string? SWW_PKWiU { get; set; }
        public string Producent { get; set; }
        public int IdTypu { get; set; }
        public string? TypProduktuNazwa { get; set; }
        public string? FotoURL { get; set; }
        public decimal StawkaVatZakupu { get; set; }
        public decimal StawkaVatSprzedazy { get; set; }
        public bool OdwrotneObciazenie { get; set; }
        public bool PodzielonaPlatnosc { get; set; }
        public decimal? StawkaCla { get; set; }
        public decimal? StwkaAkcyzy { get; set; }
        public string? KodPcn { get; set; }
        public string? Kraj { get; set; }
        public int? CzasKompletacji { get; set; }
        public bool CzyAktywna { get; set; }
        public int IdDostawcy { get; set; }
        public string? DostawcaDane { get; set; }

        public static explicit operator Produkt(ProduktyForView produktyForView)
        {
            return new Produkt().CopyPropertiesReturnExtension(produktyForView);
        }
        public static explicit operator ProduktyForView(Produkt produkt)
        {
            var produktyForView = new ProduktyForView().CopyPropertiesReturnExtension(produkt);
            produktyForView.TypProduktuNazwa = produkt.TypProduktu?.Nazwa;
            produktyForView.DostawcaDane = produkt.Dostawca?.Nazwa;
            return produktyForView;
        }
    }
}
