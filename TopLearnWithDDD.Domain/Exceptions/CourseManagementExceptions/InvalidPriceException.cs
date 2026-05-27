using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidPriceException : CourseManagementException
    {
        public InvalidPriceException() : base("Price Can Not Be Negative")
        {
            
        }
    }
}
