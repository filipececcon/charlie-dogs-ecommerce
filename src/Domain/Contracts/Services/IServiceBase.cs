using ChalieDogs.Ecommerce.Domain.Entities;

namespace ChalieDogs.Ecommerce.Domain.Contracts.Services
{
    public interface IServiceBase<TEntity> : IBase<TEntity> where TEntity : BaseEntity
    {
    }
}
