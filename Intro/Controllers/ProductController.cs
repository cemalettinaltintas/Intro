using Intro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Intro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            List<Product> urunler = new List<Product> {
                new Product{UrunBaslik="IPhone 15",UrunFiyat=80000,UrunResim="i1.png",UrunAciklama="Güzel telefon",UrunSatistaMi=true,StokAdeti=10},
                new Product{UrunBaslik="IPhone 16",UrunFiyat=85000,UrunResim="i2.png",UrunAciklama="Güzel telefon",UrunSatistaMi=true,StokAdeti=15},
                new Product{UrunBaslik="IPhone 17",UrunFiyat=90000,UrunResim="i3.png",UrunAciklama="Güzel telefon",UrunSatistaMi=false,StokAdeti=5},
                new Product{UrunBaslik="IPhone 18",UrunFiyat=95000,UrunResim="i4.png",UrunAciklama="Güzel telefon",UrunSatistaMi=false,StokAdeti=0}
            };
            return View(urunler);
        }
        public IActionResult Details()
        {
            Product urun1 = new Product();
            urun1.UrunBaslik = "Samsung Galaxy S24 Ultra";
            urun1.UrunAciklama = "Samsung Galaxy S24 Ultra 12/512 Gb Akıllı Telefon Titanyum Siyah";
            urun1.UrunFiyat = 74000;
            urun1.UrunResim = "samsung-s24.jpg";
            urun1.UrunSatistaMi = false;
            urun1.StokAdeti = 3;

            return View(urun1);
        }
    }
}