using SocialNetwork.Data.Contracts.Entities;
using System;
using System.Collections.Generic;

namespace SocialNetwork.Data.Contracts.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : BaseEntity
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);

        void Add(TEntity entity);

        void Remove(TEntity entity);

        void Commit();
    }
}
