using ChalieDogs.Ecommerce.DataAccess.Context;
using ChalieDogs.Ecommerce.Domain.Contracts.Repositories;
using ChalieDogs.Ecommerce.Domain.Entities;

namespace ChalieDogs.Ecommerce.Repository.CharlieDogs
{
    class AnimalSizeRepository : CharlieDogsRepositoryBase<AnimalSize>, IAnimalSizeRepository
    {
        protected AnimalSizeRepository(CharlieDogsContext context) : base(context)
        {
        }
    }
}
