using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Core.Models;
using SocialNetwork.Core.Services;

namespace SocialNetwork.Controllers
{
    public abstract class BaseController : Controller
    {
        private UserMetadata userMetadata;

        private readonly IUserMetadataService userMetadataService;

        protected BaseController(IUserMetadataService userMetadataService)
        {
            this.userMetadataService = userMetadataService;
        }

        protected UserMetadata UserMetadata
        {
            get
            {
                return userMetadata = userMetadata ?? userMetadataService.GetUserMetadata(User);
            }
        }
    }
}
