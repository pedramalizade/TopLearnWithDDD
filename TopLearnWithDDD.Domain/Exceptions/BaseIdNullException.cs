using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions
{
    internal class BaseIdNullException : CourseManagementException
    {
        public BaseIdNullException() : base("Id Can Not Be Empty")
        {
        }
    }
}
