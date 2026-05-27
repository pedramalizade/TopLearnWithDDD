using TopLearnWithDDD.Domain.Entities.CourseManagement;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Factories.CourseManagement
{
    public class LessonFactory : ILessonFactory
    {
        public Lesson Create(BaseId id, Title title, VideoUrl videoUrl, BaseId courseCatalogId)
        {
            return new Lesson(id, title, videoUrl, courseCatalogId);
        }
    }
}
