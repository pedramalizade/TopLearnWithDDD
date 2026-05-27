using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions
{
    public class CourseCatalogNotFoundException : CourseManagementException
    {
        public CourseCatalogNotFoundException() : base("Course Catalog Not Found...!")
        {

        }
    }
}
