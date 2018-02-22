using System;

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
                throw new Exception("Usuário em branco");
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                throw new Exception("Senha em branco");
            }
        }
    }
}
