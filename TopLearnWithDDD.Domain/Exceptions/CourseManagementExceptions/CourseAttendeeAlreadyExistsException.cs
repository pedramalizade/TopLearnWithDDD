using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    public class CourseAttendeeAlreadyExistsException : CourseManagementException
    {
        public CourseAttendeeAlreadyExistsException() : base("Course Attendee Already Exists...!")
        {

        }
    }
}
