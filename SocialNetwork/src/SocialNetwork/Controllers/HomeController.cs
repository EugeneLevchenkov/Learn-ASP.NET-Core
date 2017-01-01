using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
