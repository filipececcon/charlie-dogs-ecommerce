using ChalieDogs.Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ChalieDogs.Ecommerce.Domain.Contracts
{
    public interface IBase<TEntity> where TEntity : BaseEntity
    {
        int Add(TEntity entity);

        bool Contains(Expression<Func<TEntity, bool>> predicate);

        TEntity GetById(int id);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAllInactives();

        IEnumerable<TEntity> GetAllInclusive(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);

        void Update(TEntity entity);

        void Update(TEntity entity, params Expression<Func<TEntity, object>>[] properties);

        void Remove(TEntity entity);

        void Remove(int id);
    }
}
