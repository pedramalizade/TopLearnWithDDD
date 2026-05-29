using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Application.Exceptions
{
    public class CourseNotFoundException : CourseManagementException
    {
        public CourseNotFoundException() : base("Course Not Found...")
        {
            
        }
    }
}
