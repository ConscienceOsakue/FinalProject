using FinalProject.Models;
using Microsoft.AspNetCore.Authentication; //Copied this line
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject.Controllers
{
    /*The Controller handles user input, processes it, and communicates
    with the Model and View accordingly. It acts as an intermediary between
    the Model and View, receiving requests from the user, updating the Model,
    and then rendering the appropriate View with the updated data.*/

    // added the controller to the method

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // i use this IActionResult to call each page to display the website
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutPage()
        {
            return View();
        }

        public IActionResult AHAnalyzer()
        {
            return View();
        }

        public IActionResult ChronicleEBPosts()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Error { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
