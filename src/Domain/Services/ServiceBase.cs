using ChalieDogs.Ecommerce.Domain.Contracts.Repositories;
using ChalieDogs.Ecommerce.Domain.Contracts.Services;
using ChalieDogs.Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ChalieDogs.Ecommerce.Domain.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : BaseEntity
    {
        protected readonly IRepositoryBase<TEntity> Repository;

        protected ServiceBase(IRepositoryBase<TEntity> repository)
        {
            Repository = repository;
        }

        public int Add(TEntity entity)
        {
            entity.Validate();
            return Repository.Add(entity);
        }

        public bool Contains(Expression<Func<TEntity, bool>> predicate)
        {
            return Repository.Contains(predicate);
        }

        public TEntity GetById(int id)
        {
            return Repository.GetById(id);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return Repository.Get(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Repository.GetAll();
        }

        public IEnumerable<TEntity> GetAllInactives()
        {
            return Repository.GetAllInactives();
        }

        public IEnumerable<TEntity> GetAllInclusive(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            return Repository.GetAllInclusive(predicate, includes);
        }

        public void Update(TEntity entity)
        {
            entity.Validate();
            Repository.Update(entity);
        }

        public void Update(TEntity entity, params Expression<Func<TEntity, object>>[] properties)
        {
            entity.Validate();
            Repository.Update(entity, properties);
        }

        public void Remove(TEntity entity)
        {
            Repository.Remove(entity);
        }

        public void Remove(int id)
        {
            Repository.Remove(id);
        }
    }
}
