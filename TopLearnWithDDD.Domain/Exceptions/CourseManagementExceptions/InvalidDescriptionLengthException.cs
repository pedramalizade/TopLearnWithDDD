using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidDescriptionLengthException : CourseManagementException
    {
        public InvalidDescriptionLengthException(int validLength) : base($"Description Can not be More Than {validLength} Charactors") 
        {
            
        }
    }
}
