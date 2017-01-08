using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Business.Contracts;
using SocialNetwork.Core.Services;

namespace SocialNetwork.Controllers
{
    public class HomeController : BaseController
    {
        private IUserProfileService profileService;


        public HomeController(IUserProfileService profileService, IUserMetadataService userMetadataService) : base(userMetadataService)
        {
            this.profileService = profileService;
        } 
        
        [Authorize]
        public IActionResult Index()
        {
            var viewModel = profileService.GetViewModel(UserMetadata.UserProfile.Id);
            return View(viewModel);
        }
    }
}
