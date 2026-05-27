using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidTitleLengthException : CourseManagementException
    {
        public InvalidTitleLengthException(int validLength) : base($"Title Can not be More Than {validLength} Charactors ")
        {
            
        }
    }
}
