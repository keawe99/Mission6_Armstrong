using Microsoft.AspNetCore.Mvc;
using Mission6_Armstrong.Models;
using System.Diagnostics;

namespace Mission6_Armstrong.Controllers
{
    public class HomeController : Controller
    {

        private MoviesContext _context;
        public HomeController(MoviesContext movie) //Constructor
        {
            _context = movie;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult aboutJoel()
        {
            return View();
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult Collection()
        {
            //Linq
            var applications = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.category = _context.Categories //ViewBag
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View();
        }


        [HttpPost]
        public IActionResult Movies(Application response)
        {
            _context.Movies.Add(response); //Add record to database
            _context.SaveChanges(); //commits changes to database

            return View("Confirmation", response);
        }
    }
}
