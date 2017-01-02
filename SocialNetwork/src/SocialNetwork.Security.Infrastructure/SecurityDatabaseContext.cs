using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Security.Contracts.Entities;

namespace SocialNetwork.Security.Infrastructure
{
    public class SecurityDatabaseContext : IdentityDbContext<User>
    {
        public SecurityDatabaseContext(DbContextOptions<SecurityDatabaseContext> options) : base(options)
        {
        }
    }
}
