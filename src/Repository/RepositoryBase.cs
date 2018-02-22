using ChalieDogs.Ecommerce.Domain.Contracts.Repositories;
using ChalieDogs.Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace ChalieDogs.Ecommerce.Repository
{
    public abstract class RepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        private readonly TContext _context;

        protected RepositoryBase(TContext context)
        {
            _context = context;
        }

        public virtual int Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return _context.SaveChanges();
        }

        public virtual bool Contains(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Count(predicate) > 0;
        }

        public virtual TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {

            return _context.Set<TEntity>().Where(predicate);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().Where(x => x.Active == true).AsQueryable();
        }

        public virtual IEnumerable<TEntity> GetAllInactives()
        {
            return _context.Set<TEntity>().Where(x => x.Active == false);
        }

        public virtual IEnumerable<TEntity> GetAllInclusive(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = _context.Set<TEntity>().AsQueryable();

            query = includes.Aggregate(query, (current, include) => current.Include(include));

            return predicate != null ? query.Where(predicate).ToList() : query.ToList();
        }

        public virtual void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public virtual void Update(TEntity entity, params Expression<Func<TEntity, object>>[] properties)
        {
            _context.Set<TEntity>().Attach(entity);

            if (properties.Length > 0)
            {
                foreach (var propertyAccessor in properties)
                {
                    _context.Entry(entity).Property(propertyAccessor).IsModified = true;
                }
            }
            else
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

        public virtual void Remove(TEntity entity)
        {
            entity.Active = false;
            _context.SaveChanges();
        }

        public virtual void Remove(int id)
        {
            GetById(id).Active = false;
            _context.SaveChanges();
        }

    }
}
