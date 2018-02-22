namespace ChalieDogs.Ecommerce.Domain.Exceptions
{
    public class AccountException : BaseException
    {
        public AccountException(string prop, string message = null) : base(prop, message)
        {
        }
    }
}
