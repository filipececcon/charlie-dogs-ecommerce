using ChalieDogs.Ecommerce.Domain.Entities;

namespace ChalieDogs.Ecommerce.Domain.Contracts.Repositories
{
    public interface IRepositoryBase<TEntity> : IBase<TEntity> where TEntity : BaseEntity
    {
    }
}
