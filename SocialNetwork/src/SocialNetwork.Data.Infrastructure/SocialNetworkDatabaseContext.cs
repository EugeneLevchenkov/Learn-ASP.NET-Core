using System;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data.Contracts;
using SocialNetwork.Data.Contracts.Entities;

namespace SocialNetwork.Data.Infrastructure
{
    public class SocialNetworkDatabaseContext : DbContext, IDatabaseContext
    {
        public SocialNetworkDatabaseContext(DbContextOptions<SocialNetworkDatabaseContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts
        {
            get;
            set;
        }

        public DbSet<UserProfile> UserProfiles
        {
            get;
            set;
        }

        public object GetSet<TEntity>() where TEntity : BaseEntity
        {
            return Set<TEntity>();
        }

        void IDatabaseContext.SaveChanges()
        {
            SaveChanges();
        }
    }
}
