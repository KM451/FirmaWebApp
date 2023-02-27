using FirmaMobile.ServiceReference;

namespace FirmaMobile.Models
{
    public class AdresyForView
    {
        public int IdAdresu { get; set; }
        public string Ulica { get; set; }
        public string Miejscowosc { get; set; }
        public string NrDomu { get; set; }
        public string NrLokalu { get; set; }
        public string KodPoczowy { get; set; }
        public string Poczta { get; set; }
        public string Kraj { get; set; }
        public bool Siedziba { get; set; }
        public bool Glowny { get; set; }
        public int IdKontrahenta { get; set; }
        public AdresyForView() { }
        public AdresyForView(Adres adres)
        {
            IdAdresu = adres.IdAdresu;
            Ulica = adres.Ulica;
            Miejscowosc = adres.Miejscowosc;
            NrDomu = adres.NrDomu;
            NrLokalu = adres.NrLokalu;
            KodPoczowy = adres.KodPoczowy;
            Poczta = adres.Poczta;
            Kraj = adres.Kraj;
            Siedziba = adres.Siedziba;
            Glowny = adres.Glowny;
            IdKontrahenta = adres.IdKontrahenta;
        }
    }
}
