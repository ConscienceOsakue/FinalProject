using FinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;

// ChronicleEBPostController.cs
namespace FinalProject.Controllers
{
    [Authorize]
    public class BlogController : Controller
    {
        private readonly IBlogRepository _repo;
        private readonly UserManager<IdentityUser> _userManager;

        public BlogController(IBlogRepository repo, UserManager<IdentityUser> userManager)
        {
            _repo = repo;
            _userManager = userManager;
        }

        public IActionResult Blog()
        {
            return View("InsertBlog");
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> InsertBlog(Blog blogToInsert)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                blogToInsert.PostAuthor = user.Email;
                _repo.InsertBlog(blogToInsert);
            } 
            else
            {
                return View("Error");
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Index()
        {
            var posts = _repo.GetAllBlog();
            return View(posts);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult UpdateBlog(int id)
        {
            var post = _repo.GetBlogById(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult UpdateBlog(Blog post)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateBlog(post);
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult DeleteBlog(int id)
        {
            var post = _repo.GetBlogById(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteConfirmed(int PostId) // Here was changed from "ChronicleEBPost Id" to "int postId"
        {
            _repo.DeleteBlog(PostId); // was changed from "id" to "postId"
            return RedirectToAction(nameof(Index));
        }

        public IActionResult GetBlog(int PostId)
        {
            var post = _repo.GetBlogById(PostId);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }
    }
}

