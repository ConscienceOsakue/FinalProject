using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class BlogCommentsController : Controller
    {
        // Implementing the action methods for creating, reading, updating, and deleting comments
        private readonly ICommentsRepository repo;

        public BlogCommentsController(ICommentsRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult ChronicleEBComments()
        {
            return View();
        }
    }
}
