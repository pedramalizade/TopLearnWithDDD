using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class DescriptionNullOrEmptyException : CourseManagementException
    {
        public DescriptionNullOrEmptyException() : base("Description Can not be Empty")
        {
            
        }
    }
}
