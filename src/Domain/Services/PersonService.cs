using ChalieDogs.Ecommerce.Domain.Contracts.Repositories;
using ChalieDogs.Ecommerce.Domain.Contracts.Services;
using ChalieDogs.Ecommerce.Domain.Entities;

namespace ChalieDogs.Ecommerce.Domain.Services
{
    public class PersonService : ServiceBase<Person>, IPersonService
    {
        protected PersonService(IPersonRepository repository) : base(repository)
        {
        }
    }
}
