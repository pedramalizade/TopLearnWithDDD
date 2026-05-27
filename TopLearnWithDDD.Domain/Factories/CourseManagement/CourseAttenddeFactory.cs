using TopLearnWithDDD.Domain.Entities.CourseManagement;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Factories.CourseManagement
{
    public class CourseAttenddeFactory : ICourseAttenddeFactory
    {
        public CourseAttendee Create(BaseId id, BaseId coursId, BaseId userId)
        {
            return new CourseAttendee(id, coursId, userId);
        }
    }
}
