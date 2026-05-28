using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    public class InvalidInstructorExperienceException : CourseManagementException
    {
        public InvalidInstructorExperienceException() : base("Experience Could Not Be Less Than 3 Charactors")
        {
        }
    }
}
