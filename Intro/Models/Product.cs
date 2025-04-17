namespace Intro.Models
{
    public class Product
    {
        public string? UrunBaslik { get; set; }
        public string UrunAciklama { get; set; } = null!;
        public double UrunFiyat { get; set; }
        public string? UrunResim { get; set; }
        public bool UrunSatistaMi { get; set; }
    }
}
