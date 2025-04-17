

using Intro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Intro.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Course> kurslar = new List<Course>
            {
                new Course{Title="Django Kursu",Image="1.jpg",Description="Lorem, ipsum dolor"},
                new Course{Title="Javascript Kursu",Image="2.jpg",Description="Lorem, ipsum dolor"},
                new Course{Title="Asp.Net Core Kursu",Image="3.jpg",Description="Lorem, ipsum dolor"},
            };

            return View(kurslar);
        }
        public IActionResult Details()
        {
            Course course1=new Course();
            course1.Title = "Django Kursu";
            course1.Image = "1.jpg";
            course1.Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Unde, similique!";

            return View(course1);
        }
    }
}
