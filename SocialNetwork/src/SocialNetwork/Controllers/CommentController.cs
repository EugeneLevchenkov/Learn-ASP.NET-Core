using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Business.Contracts.ViewModels;

namespace SocialNetwork.Controllers
{
    public class CommentController : Controller
    {
        [HttpGet]
        public IActionResult Create(int postId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EditCommentViewModel viewModel)
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(EditCommentViewModel viewModel)
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
