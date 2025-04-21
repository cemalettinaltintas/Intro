

using Intro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Intro.Controllers
{
    public class CourseController : Controller
    {
        List<Course> kurslar = new List<Course>
            {
                new Course{Id=1, Title="Django Kursu",Image="1.jpg",Description="Lorem, ipsum dolor",IsHome=true},
                new Course{Id=2,Title="Javascript Kursu",Image="2.jpg",Description="Lorem, ipsum dolor",IsHome=true},
                new Course{Id=3,Title="Asp.Net Core Kursu",Image="3.jpg",Description="Lorem, ipsum dolor",IsHome=false},
                new Course{Id=4,Title="Angular Kursu",Image="4.jpg",Description="Lorem, ipsum dolor",IsHome=false}
            };

        public IActionResult Index()
        {
            return View(kurslar);
        }
        public IActionResult List()
        {

            return View(kurslar);
        }
        public IActionResult Details(int id)
        {
            Course? kurs=kurslar.Where(k => k.Id == id).FirstOrDefault();
            return View(kurs);
        }
    }
}
