using ChalieDogs.Ecommerce.Domain.Entities;

namespace ChalieDogs.Ecommerce.DataAccess.Configs
{
    public class AnimalConfiguration : BaseConfiguration<Animal>
    {
        public AnimalConfiguration()
        {
            ToTable("TB_ANIMAL");

            Property(x => x.Picture)
                .IsRequired()
                .HasColumnName("DS_FOTO");

            Property(x => x.Price)
                .IsRequired()
                .HasColumnName("VL_PRECO");

            Property(x => x.Age)
                .IsRequired()
                .HasColumnName("NR_IDADE");

            Property(x => x.Description)
                .IsRequired()
                .HasColumnName("DS_ANIMAL");

            Property(x => x.AnimalSizeId)
                .HasColumnName("ID_ANIMAL_TAMANHO");

            HasRequired(x => x.AnimalSize)
                .WithMany(x => x.Animals)
                .HasForeignKey(x => x.AnimalSizeId);
        }
    }
}
