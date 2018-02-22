using System;
using System.Collections.Generic;

namespace ChalieDogs.Ecommerce.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        #region Relationships

        public virtual List<Account> Accounts { get; set; }

        #endregion

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new Exception("Nome em branco");
            }

            if (string.IsNullOrWhiteSpace(CPF))
            {
                throw new Exception("CPF em branco");
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                throw new Exception("Email em branco");
            }
        }
    }
}
