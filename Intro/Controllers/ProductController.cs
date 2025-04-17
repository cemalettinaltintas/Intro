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
            return View();
        }
        public IActionResult Details()
        {    
            Product urun1= new Product();
            urun1.UrunBaslik = "Samsung Galaxy S24 Ultra";
            urun1.UrunAciklama= "Samsung Galaxy S24 Ultra 12/512 Gb Akıllı Telefon Titanyum Siyah";
            urun1.UrunFiyat= 74000;
            urun1.UrunResim= "samsung-s24.jpg";
            urun1.UrunSatistaMi = false;

            return View(urun1);
        }
    }
}