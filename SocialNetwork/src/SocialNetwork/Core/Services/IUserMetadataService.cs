using SocialNetwork.Core.Models;
using System.Security.Claims;

namespace SocialNetwork.Core.Services
{
    public interface IUserMetadataService
    {
        UserMetadata GetUserMetadata(ClaimsPrincipal user);
    }
}
