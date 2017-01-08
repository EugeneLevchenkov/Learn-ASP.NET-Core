using System;
using System.Security.Claims;
using SocialNetwork.Core.Models;
using SocialNetwork.Security.Contracts.Entities;
using Microsoft.AspNetCore.Identity;
using SocialNetwork.Business.Contracts;

namespace SocialNetwork.Core.Services
{
    public class UserMetadataService : IUserMetadataService
    {
        private readonly UserManager<User> userManager;
        private readonly IUserProfileService profileService;

        public UserMetadataService(UserManager<User> userManager, IUserProfileService profileService)
        {
            this.userManager = userManager;
            this.profileService = profileService;
        }

        public UserMetadata GetUserMetadata(ClaimsPrincipal user)
        {
            var userId = userManager.GetUserId(user);
            var userProfile = profileService.GetByUserId(userId);

            return new UserMetadata
            {
                Principal = user,
                UserProfile = userProfile
            };
        }
    }
}
