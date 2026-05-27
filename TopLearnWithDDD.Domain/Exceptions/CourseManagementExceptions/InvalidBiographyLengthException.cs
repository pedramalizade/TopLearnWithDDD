using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidBiographyLengthException : CourseManagementException
    {
        public InvalidBiographyLengthException() : base("Biography Can not be More Than 300 Charactors")
        {
            
        }
    }
}
