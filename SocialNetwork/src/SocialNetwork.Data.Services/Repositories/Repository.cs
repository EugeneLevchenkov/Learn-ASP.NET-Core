using System;
using System.Collections.Generic;
using SocialNetwork.Data.Contracts.Repositories;
using SocialNetwork.Data.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SocialNetwork.Data.Contracts;

namespace SocialNetwork.Data.Services.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {

        protected DbSet<TEntity> Set;
        protected IDatabaseContext Context;

        public Repository(IDatabaseContext context)
        {
            Set = (DbSet<TEntity>)context.GetSet<TEntity>();
            Context = context;
        }

        public void Add(TEntity entity)
        {
            Set.Add(entity);      
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return Set.AsQueryable().Where(predicate).ToList();
        }

        public TEntity GetById(int id)
        {
            return Set.Find(id);
        }

        public void Remove(TEntity entity)
        {
            Set.Remove(entity);
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}
