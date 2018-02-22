using ChalieDogs.Ecommerce.Domain.Entities;

namespace ChalieDogs.Ecommerce.DataAccess.Configs
{
    public class AccountConfiguration : BaseConfiguration<Account>
    {
        public AccountConfiguration()
        {
            ToTable("TB_CONTAS");

            Property(x => x.Username)
                .IsRequired()
                .HasColumnName("NM_USUARIO");

            Property(x => x.Password)
                .IsRequired()
                .HasColumnName("DS_SENHA");

            Property(x => x.PersonId)
                .HasColumnName("ID_PESSOA");

            HasRequired(x => x.Person)
                .WithMany(x => x.Accounts)
                .HasForeignKey(x => x.PersonId);

        }
    }
}
