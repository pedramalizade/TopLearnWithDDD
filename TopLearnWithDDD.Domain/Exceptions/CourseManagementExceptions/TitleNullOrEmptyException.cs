using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class TitleNullOrEmptyException : CourseManagementException
    {
        public TitleNullOrEmptyException() : base("Title Can Not Be Empty")
        {
            
        }
    }
}
