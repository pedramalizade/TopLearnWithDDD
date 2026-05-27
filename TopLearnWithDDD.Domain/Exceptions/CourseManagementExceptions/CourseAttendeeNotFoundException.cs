using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    public class CourseAttendeeNotFoundException : CourseManagementException
    {
        public CourseAttendeeNotFoundException() : base("Course Attendee Not Found...")
        {

        }
    }
}
