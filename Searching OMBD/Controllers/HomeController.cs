using Microsoft.AspNetCore.Mvc;
using Searching_OMBD.Models;
using System.Diagnostics;

namespace Searching_OMBD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieSearch()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieSearch(string Title)
        {
            MovieModel result = MovieDAL.GetMovie(Title);
            return View(result );
        }
        [HttpGet]
        public IActionResult MovieNight()
        {
            return View();
        }
        [HttpPost]  
        public IActionResult MovieNight(string Title1,string Title2,string Title3)
        {
            List<MovieModel> result = new List<MovieModel>();
            result.Add(MovieDAL.GetMovie(Title1));
            result.Add(MovieDAL.GetMovie(Title2));
            result.Add(MovieDAL.GetMovie(Title3));
            return View(result);

            
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}