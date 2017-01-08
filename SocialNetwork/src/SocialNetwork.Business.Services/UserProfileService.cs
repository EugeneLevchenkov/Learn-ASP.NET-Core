using System;
using SocialNetwork.Business.Contracts;
using SocialNetwork.Business.Contracts.ViewModels;
using SocialNetwork.Data.Contracts.Repositories;
using SocialNetwork.Data.Contracts.Entities;
using AutoMapper;
using SocialNetwork.Business.Contracts.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Business.Services
{
    public class UserProfileService : IUserProfileService
    {
        private IRepository<UserProfile> userProfileRepository;
        private IMapper mapper;

        public UserProfileService(IMapper mapper, IRepository<UserProfile> userProfileRepository)
        {
            this.mapper = mapper;
            this.userProfileRepository = userProfileRepository;
        }

        public ProfileViewModel GetViewModel(int profileId)
        {
            var userProfile = userProfileRepository.GetById(profileId);
            var viewModel = mapper.Map<ProfileViewModel>(userProfile);
            return viewModel;
        }

        public UserProfileInfo GetByUserId(string userId)
        {
            var userProfiles = userProfileRepository.Get(x => x.UserId == userId);
            var userProfile = userProfiles.Single();
            var result = mapper.Map<UserProfileInfo>(userProfile);
            return result;
        }

        public Task<UserProfileInfo> CreateUserProfileAsync(string userId)
        {
            return Task.Run(() =>
            {
                var userProfile = new UserProfile
                {
                    UserId = userId
                };

                userProfileRepository.Add(userProfile);
                userProfileRepository.Commit();

                var result = mapper.Map<UserProfileInfo>(userProfile);
                return result;
            });
        }
    }
}
