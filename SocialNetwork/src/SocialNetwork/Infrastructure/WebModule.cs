using Autofac;
using SocialNetwork.Core.Services;

namespace SocialNetwork.Infrastructure
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserMetadataService>().As<IUserMetadataService>();
        }
    }
}
