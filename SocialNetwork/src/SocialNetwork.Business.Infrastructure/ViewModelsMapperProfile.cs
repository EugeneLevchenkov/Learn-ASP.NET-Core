using AutoMapper;
using SocialNetwork.Business.Contracts.ViewModels;
using SocialNetwork.Data.Contracts.Entities;

namespace SocialNetwork.Business.Infrastructure
{
    public class ViewModelsMapperProfile : Profile
    {
        public ViewModelsMapperProfile()
        {
            MapUserProfileToProfileViewModel();
            MapPostToPostViewModel();
            MapCommentToCommentViewModel();
        }

        private void MapUserProfileToProfileViewModel()
        {
            CreateMap<UserProfile, ProfileViewModel>()
                .ForMember(viewModel => viewModel.Id, c => c.MapFrom(entity => entity.Id))
                .ForMember(viewModel => viewModel.FirstName, c => c.MapFrom(entity => entity.FirstName))
                .ForMember(viewModel => viewModel.LastName, c => c.MapFrom(entity => entity.LastName))
                .ForMember(viewModel => viewModel.Posts, c => c.MapFrom(entity => entity.Posts));
        }

        private void MapPostToPostViewModel()
        {
            CreateMap<Post, PostViewModel>()
                .ForMember(viewModel => viewModel.Id, c => c.MapFrom(entity => entity.Id))
                .ForMember(viewModel => viewModel.Content, c => c.MapFrom(entity => entity.Content))
                .ForMember(viewModel => viewModel.Comments, c => c.MapFrom(entity => entity.Comments));
        }

        private void MapCommentToCommentViewModel()
        {
            CreateMap<Comment, CommentViewModel>()
                .ForMember(viewModel => viewModel.Id, c => c.MapFrom(entity => entity.Id))
                .ForMember(viewModel => viewModel.Content, c => c.MapFrom(entity => entity.Content));
        }
    }
}
