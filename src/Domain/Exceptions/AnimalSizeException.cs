namespace ChalieDogs.Ecommerce.Domain.Exceptions
{
    public class AnimalSizeException : BaseException
    {
        public AnimalSizeException(string prop, string message = null) : base(prop, message)
        {
        }
    }
}
