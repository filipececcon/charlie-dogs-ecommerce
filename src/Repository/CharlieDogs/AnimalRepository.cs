using ChalieDogs.Ecommerce.DataAccess.Context;
using ChalieDogs.Ecommerce.Domain.Contracts.Repositories;
using ChalieDogs.Ecommerce.Domain.Entities;

namespace ChalieDogs.Ecommerce.Repository.CharlieDogs
{
    public class AnimalRepository : CharlieDogsRepositoryBase<Animal>, IAnimalRepository
    {
        protected AnimalRepository(CharlieDogsContext context) : base(context)
        {
        }
    }
}
