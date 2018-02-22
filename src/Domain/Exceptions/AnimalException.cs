
namespace ChalieDogs.Ecommerce.Domain.Exceptions
{
    public class AnimalException : BaseException
    {
        public AnimalException(string prop, string message = null) : base(prop, message)
        {
        }
    }
}
