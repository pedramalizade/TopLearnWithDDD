using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    public class InvalidInstructorRatingException : CourseManagementException
    {
        public InvalidInstructorRatingException() : base("Rating Could Not Be Negative")
        {

        }
    }
}
