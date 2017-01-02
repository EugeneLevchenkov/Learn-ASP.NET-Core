using SocialNetwork.Data.Contracts.Entities;

namespace SocialNetwork.Data.Contracts
{
    public interface IDatabaseContext
    {
        object GetSet<TEntity>() where TEntity : BaseEntity;

        void SaveChanges();
    }
}
