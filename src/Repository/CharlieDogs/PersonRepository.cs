using ChalieDogs.Ecommerce.DataAccess.Context;
using ChalieDogs.Ecommerce.Domain.Contracts.Repositories;
using ChalieDogs.Ecommerce.Domain.Entities;

namespace ChalieDogs.Ecommerce.Repository.CharlieDogs
{
    class PersonRepository : CharlieDogsRepositoryBase<Person>, IPersonRepository
    {
        protected PersonRepository(CharlieDogsContext context) : base(context)
        {
        }
    }
}
