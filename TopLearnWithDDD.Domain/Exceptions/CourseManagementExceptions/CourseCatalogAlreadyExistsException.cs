using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    public class CourseCatalogAlreadyExistsException : CourseManagementException
    {
        public CourseCatalogAlreadyExistsException() : base("Course Catalog Already Exists...")
        {

        }
    }
}
