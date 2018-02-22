using ChalieDogs.Ecommerce.DataAccess.Context;
using ChalieDogs.Ecommerce.Domain.Entities;

namespace ChalieDogs.Ecommerce.Repository.CharlieDogs
{
    public class CharlieDogsRepositoryBase<TEntity> : RepositoryBase<TEntity, CharlieDogsContext> where TEntity : BaseEntity
    {
        protected CharlieDogsRepositoryBase(CharlieDogsContext context) : base(context)
        {
        }
    }
}
