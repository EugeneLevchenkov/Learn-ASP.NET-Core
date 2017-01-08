using Autofac;
using SocialNetwork.Business.Contracts;
using SocialNetwork.Business.Services;

namespace SocialNetwork.Business.Infrastructure
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserProfileService>().As<IUserProfileService>();
        }
    }
}
