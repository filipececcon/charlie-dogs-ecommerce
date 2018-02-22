using ChalieDogs.Ecommerce.Domain.Entities;

namespace ChalieDogs.Ecommerce.DataAccess.Configs
{
    public class PersonConfguration : BaseConfiguration<Person>
    {
        public PersonConfguration()
        {
            ToTable("TB_ARENA");

            Property(x => x.Name)
                .IsRequired()
                .HasColumnName("NM_PESSOA");

            Property(x => x.CPF)
                .IsRequired()
                .HasColumnName("DS_CPF");

            Property(x => x.Email)
                .IsRequired()
                .HasColumnName("DS_EMAIL");
        }
    }
}
