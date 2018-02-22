namespace ChalieDogs.Ecommerce.Domain.Exceptions
{
    public class PersonException : BaseException
    {
        public PersonException(string prop, string message = null) : base(prop, message)
        {
        }
    }
}
