using ChalieDogs.Ecommerce.Domain.Contracts.Repositories;
using ChalieDogs.Ecommerce.Domain.Contracts.Services;
using ChalieDogs.Ecommerce.Domain.Entities;

namespace ChalieDogs.Ecommerce.Domain.Services
{
    public class AnimalService : ServiceBase<Animal>, IAnimalService
    {
        protected AnimalService(IAnimalRepository repository) : base(repository)
        {
        }
    }
}
