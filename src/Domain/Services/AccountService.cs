using ChalieDogs.Ecommerce.Domain.Contracts.Repositories;
using ChalieDogs.Ecommerce.Domain.Contracts.Services;
using ChalieDogs.Ecommerce.Domain.Entities;

namespace ChalieDogs.Ecommerce.Domain.Services
{
    public class AccountService : ServiceBase<Account>, IAccountService
    {
        protected AccountService(IAccountRepository repository) : base(repository)
        {
        }
    }
}
