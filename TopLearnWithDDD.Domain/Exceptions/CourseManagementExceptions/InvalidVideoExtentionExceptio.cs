using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    internal class InvalidVideoExtentionExceptio : CourseManagementException
    {
        public InvalidVideoExtentionExceptio() : base("Only .MP4 is Valid Extention For Videos...")
        {
            
        }
    }
}
