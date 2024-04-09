using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    //The Controller handles user input, processes it, and communicates
    //with the Model and View accordingly. It acts as an intermediary between
    //the Model and View, receiving requests from the user, updating the Model,
    //and then rendering the appropriate View with the updated data.

    // added the controller to the method
    public class AboutPageController : Controller
    {
        private readonly ILogger<AboutPageController> _logger;

        public AboutPageController(ILogger<AboutPageController> logger)
        {
            _logger = logger;
        }

        public IActionResult AboutPage()
        {
            return View();
        }
        
    }
}



