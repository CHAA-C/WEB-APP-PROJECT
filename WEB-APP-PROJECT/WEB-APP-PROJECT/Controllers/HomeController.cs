using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WEB_APP_PROJECT.Data;
using WEB_APP_PROJECT.Models;

namespace WEB_APP_PROJECT.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable <FoodCourt> allFood = _db.FoodCourts;

            return View(allFood);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult LoginSuccessView()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}