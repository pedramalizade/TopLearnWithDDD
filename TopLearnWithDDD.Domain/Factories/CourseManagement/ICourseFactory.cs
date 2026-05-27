using TopLearnWithDDD.Domain.Entities.CourseManagement;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Factories.CourseManagement
{
    public interface ICourseFactory
    {
        Course Create(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId);
    }
}
