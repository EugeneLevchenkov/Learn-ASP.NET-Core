using Microsoft.EntityFrameworkCore;
using SocialNetwork.Data.Contracts.Entities;

namespace SocialNetwork.Data.Infrastructure
{
    public class SocialNetworkDatabaseContext : DbContext
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
    }
}
