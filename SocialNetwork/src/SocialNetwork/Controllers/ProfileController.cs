using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Business.Contracts.ViewModels;

namespace SocialNetwork.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(EditProfileViewModel viewModel)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
