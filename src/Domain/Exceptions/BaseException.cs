using System;

namespace ChalieDogs.Ecommerce.Domain.Exceptions
{
    public class BaseException : Exception
    {
        public BaseException(string prop, string message = null) 
            : base(string.IsNullOrWhiteSpace(message) ? string.Format("O campo '{0}' é obrigatório", prop) : message)
        {
        }

        public BaseException(string message, Exception inner) : base(message, inner) { }
        
    }
}
