using TopLearnWithDDD.Domain.Entities.CourseManagement;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Factories.CourseManagement
{
    public interface ICourseCatalogFactory
    {
        CourseCatalog Create(BaseId id, Title title, Description description, BaseId courseId);
    }
}
