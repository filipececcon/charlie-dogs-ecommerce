using ChalieDogs.Ecommerce.Domain.Exceptions;

namespace ChalieDogs.Ecommerce.Domain.Entities
{
    public class Animal : BaseEntity
    {
        public Animal()
        {
            AnimalSize = new AnimalSize();
        }

        public string Picture { get; set; }

        public decimal Price { get; set; }

        public int Age { get; set; }

        public string Description { get; set; }

        #region Relationships

        public int AnimalSizeId { get; set; }

        public virtual AnimalSize AnimalSize { get; set; }

        #endregion

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Picture))
            {
                throw new AnimalException("Foto");
            }

            if (Price < 0)
            {
                throw new AnimalException("Preço", "Preço menor que zero");
            }

            if (Age < 0)
            {
                throw new AnimalException("Idade", "Idade menor que zero");
            }

            AnimalSize.Validate();
        }
    }
}
