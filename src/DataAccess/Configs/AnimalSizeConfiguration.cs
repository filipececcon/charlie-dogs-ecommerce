using ChalieDogs.Ecommerce.Domain.Entities;

namespace ChalieDogs.Ecommerce.DataAccess.Configs
{
    public class AnimalSizeConfiguration : BaseConfiguration<AnimalSize>
    {
        public AnimalSizeConfiguration()
        {
            ToTable("TB_ANIMAL_TAMANHO");

            Property(x => x.Size)
                .IsRequired()
                .HasColumnName("DS_TAMANHO");
        }

    }
}
