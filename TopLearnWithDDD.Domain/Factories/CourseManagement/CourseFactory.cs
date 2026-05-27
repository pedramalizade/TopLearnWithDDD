using TopLearnWithDDD.Domain.Entities.CourseManagement;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Factories.CourseManagement
{
    public class CourseFactory : ICourseFactory
    {
        public Course Create(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId)
        {
            return new Course(id, title, description, isFree, price, instructorId);
        }
    }
}
