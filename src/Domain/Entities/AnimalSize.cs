using ChalieDogs.Ecommerce.Domain.Exceptions;
using System.Collections.Generic;

namespace ChalieDogs.Ecommerce.Domain.Entities
{
    public class AnimalSize : BaseEntity
    {
        public string Size { get; set; }

        public virtual List<Animal> Animals { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Size))
            {
                throw new AnimalSizeException("Tamanho");
            }
        }
    }
}
