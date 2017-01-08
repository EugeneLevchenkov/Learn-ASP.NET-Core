using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Business.Contracts;
using SocialNetwork.Core.Services;

namespace SocialNetwork.Controllers
{
    public class HomeController : Controller
    {
        private IUserProfileService profileService;
        private IUserMetadataService userMetadataService;


        public HomeController(IUserProfileService profileService, IUserMetadataService userMetadataService)
        {
            this.profileService = profileService;
            this.userMetadataService = userMetadataService;
        } 

        
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var metadata = userMetadataService.GetUserMetadata(User);
                var viewModel = profileService.GetViewModel(metadata.UserProfile.Id);
                return View(viewModel);
            }

            return RedirectToAction("Login", "Account");
        }
    }
}
