using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class FullNameNullOrEmptyException : CourseManagementException
    {
        public FullNameNullOrEmptyException() : base("FullName Can not be Empty")
        {
            
        }
    }
}
