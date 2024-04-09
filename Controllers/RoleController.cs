using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class RoleController : Controller
    {
        private RoleManager<IdentityRole> roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateRoles()
        {
            roleManager.CreateAsync(new IdentityRole("Admin"));
            return RedirectToAction("Index", "Home");
        }
    }
}
