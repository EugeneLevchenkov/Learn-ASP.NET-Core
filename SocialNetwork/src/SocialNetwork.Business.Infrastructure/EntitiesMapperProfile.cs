using AutoMapper;
using SocialNetwork.Business.Contracts.Entities;
using SocialNetwork.Data.Contracts.Entities;

namespace SocialNetwork.Business.Infrastructure
{
    public class EntitiesMapperProfile : Profile
    {
        public EntitiesMapperProfile()
        {
            MapUserProfileToUserProfileInfo();
        }

        private void MapUserProfileToUserProfileInfo()
        {
            CreateMap<UserProfile, UserProfileInfo>()
                .ForMember(viewModel => viewModel.Id, c => c.MapFrom(entity => entity.Id))
                .ForMember(viewModel => viewModel.FirstName, c => c.MapFrom(entity => entity.FirstName))
                .ForMember(viewModel => viewModel.LastName, c => c.MapFrom(entity => entity.LastName));
        }
    }
}
