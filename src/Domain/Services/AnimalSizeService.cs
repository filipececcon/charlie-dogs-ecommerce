using ChalieDogs.Ecommerce.Domain.Contracts.Repositories;
using ChalieDogs.Ecommerce.Domain.Contracts.Services;
using ChalieDogs.Ecommerce.Domain.Entities;

namespace ChalieDogs.Ecommerce.Domain.Services
{
    public class AnimalSizeService : ServiceBase<AnimalSize>, IAnimalSizeService
    {
        protected AnimalSizeService(IAnimalSizeRepository repository) : base(repository)
        {
        }
    }
}
