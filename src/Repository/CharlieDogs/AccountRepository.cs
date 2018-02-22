using ChalieDogs.Ecommerce.DataAccess.Context;
using ChalieDogs.Ecommerce.Domain.Entities;
using ChalieDogs.Ecommerce.Domain.Contracts.Repositories;

namespace ChalieDogs.Ecommerce.Repository.CharlieDogs
{
    public class AccountRepository : CharlieDogsRepositoryBase<Account>, IAccountRepository
    {
        protected AccountRepository(CharlieDogsContext context) : base(context)
        {
        }
    }
}
