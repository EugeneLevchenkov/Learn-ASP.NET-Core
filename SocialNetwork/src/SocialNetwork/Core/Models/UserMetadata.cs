using SocialNetwork.Business.Contracts.Entities;
using System.Security.Claims;

namespace SocialNetwork.Core.Models
{
    public class UserMetadata
    {
        public UserProfileInfo UserProfile
        {
            get;
            set;
        }

        public ClaimsPrincipal Principal
        {
            get;
            set;
        }
    }
}
