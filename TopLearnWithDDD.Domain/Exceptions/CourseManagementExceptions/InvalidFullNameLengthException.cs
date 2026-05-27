using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidFullNameLengthException : CourseManagementException
    {
        public InvalidFullNameLengthException(int validLength) : base($"FullName Can not be More Than {validLength} Charactors")
        {
            
        }
    }
}
