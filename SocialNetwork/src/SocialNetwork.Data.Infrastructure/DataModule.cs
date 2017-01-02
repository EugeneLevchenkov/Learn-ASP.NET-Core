using Autofac;
using SocialNetwork.Data.Contracts;
using SocialNetwork.Data.Contracts.Entities;
using SocialNetwork.Data.Contracts.Repositories;
using SocialNetwork.Data.Services.Repositories;

namespace SocialNetwork.Data.Infrastructure
{
    public class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SocialNetworkDatabaseContext>().As<IDatabaseContext>();
            builder.RegisterType<Repository<Comment>>().As<IRepository<Comment>>();
            builder.RegisterType<Repository<Post>>().As<IRepository<Post>>();
            builder.RegisterType<Repository<UserProfile>>().As<IRepository<UserProfile>>();
        }
    }
}
