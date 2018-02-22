using ChalieDogs.Ecommerce.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ChalieDogs.Ecommerce.DataAccess.Configs
{
    public class BaseConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        protected BaseConfiguration()
        {
            //Primary Key
            HasKey(b => b.Id);

            //Custom Colums Name
            Property(b => b.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnOrder(0);

            Property(b => b.Active)
                .IsRequired()
                .HasColumnName("ST_ATIVO");

            Property(b => b.DateCreate)
                .IsRequired()
                .HasColumnName("DT_CRIACAO");

            Property(b => b.DateUpdate)
                .IsRequired()
                .HasColumnName("DT_ATUALIZACAO");
        }
    }
}
