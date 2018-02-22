using ChalieDogs.Ecommerce.Domain.Exceptions;

namespace ChalieDogs.Ecommerce.Domain.Entities
{
    public class Account : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }

        #region Relationships

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        #endregion

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                throw new AccountException("Usuário");
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                throw new AccountException("Senha");
            }
        }
    }
}
