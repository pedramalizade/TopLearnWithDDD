using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class BiographyNullOrEmptyException : CourseManagementException
    {
        public BiographyNullOrEmptyException() : base("Biography Can not be Empty")
        {
            
        }
    }
}
