using TopLearnWithDDD.Domain.Entities.CourseManagement;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Factories.CourseManagement
{
    public interface ICourseAttenddeFactory
    {
        CourseAttendee Create(BaseId id, BaseId coursId, BaseId userId);
    }
}
