using TopLearnWithDDD.Domain.Entities.CourseManagement;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Factories.CourseManagement
{
    public interface ILessonFactory
    {
        Lesson Create(BaseId id, Title title, VideoUrl videoUrl, BaseId courseCatalogId);
    }
}
