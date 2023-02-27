using Firma.Data.Model;
using Firma.Utils.Extensions;

namespace FirmaWebApi.ViewModel
{
    public class PozycjeZZForView
    {
        public int IdPozycjiZleceniaZakupu { get; set; }
        public int IdZleceniaZakupu { get; set; }
        public string? ZlecenieZakupuDane { get; set; }
        public int IdProduktu { get; set; }
        public string? ProduktDane { get; set; }
        public string? ProduktJednostkaMiary { get; set; }
        public decimal Ilosc { get; set; }
        public decimal Rabat { get; set; }
        public DateTime DataRealizacji { get; set; }

        public static explicit operator PozycjaZZ(PozycjeZZForView pozycjeZZForView)
        {
            return new PozycjaZZ().CopyPropertiesReturnExtension(pozycjeZZForView);
        }
        public static explicit operator PozycjeZZForView(PozycjaZZ pozycjaZZ)
        {
            var pozycjeZZForView = new PozycjeZZForView().CopyPropertiesReturnExtension(pozycjaZZ);
            pozycjeZZForView.ZlecenieZakupuDane = "Nr: " + pozycjaZZ.ZlecenieZakupu.IdZleceniaZakupu.ToString() + " z dnia: " +
                                                    pozycjaZZ.ZlecenieZakupu?.DataWystawienia.ToString("d");
            pozycjeZZForView.ProduktDane = pozycjaZZ.Produkt?.Kod + ", " + pozycjaZZ.Produkt?.Nazwa;
            pozycjeZZForView.ProduktJednostkaMiary = pozycjaZZ.Produkt?.JednostkaMiary;
            return pozycjeZZForView;
        }

    }
}
