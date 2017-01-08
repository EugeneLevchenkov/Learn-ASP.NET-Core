using SocialNetwork.Business.Contracts.Entities;
using SocialNetwork.Business.Contracts.ViewModels;
using System.Threading.Tasks;

namespace SocialNetwork.Business.Contracts
{
    public interface IUserProfileService
    {
        ProfileViewModel GetViewModel(int profileId);

        UserProfileInfo GetByUserId(string userId);

        Task<UserProfileInfo> CreateUserProfileAsync(string userId);
    }
}
