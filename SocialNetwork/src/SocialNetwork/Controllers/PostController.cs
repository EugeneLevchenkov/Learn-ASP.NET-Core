using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Business.Contracts.ViewModels;

namespace SocialNetwork.Controllers
{
    public class PostController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EditPostViewModel viewModel)
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(EditPostViewModel viewModel)
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
