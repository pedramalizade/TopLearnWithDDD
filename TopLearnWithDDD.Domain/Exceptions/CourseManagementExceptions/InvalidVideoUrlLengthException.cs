using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidVideoUrlLengthException : CourseManagementException
    {
        public InvalidVideoUrlLengthException(int validLength) : base($"VideoUrl Can not be More Than {validLength} Charactors")
        {
            
        }
    }
}
