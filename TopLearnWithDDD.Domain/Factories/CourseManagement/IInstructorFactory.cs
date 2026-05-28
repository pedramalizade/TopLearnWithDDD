using TopLearnWithDDD.Domain.Entities.CourseManagement;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Factories.CourseManagement
{
    public interface IInstructorFactory
    {
        Instructor CreateWithoutExperienceAndRating(BaseId id, FullName fullName, Biography biography);
        Instructor CreateWithExperienceAndWithoutRating(BaseId id, FullName fullName, Biography biography, int experience);
        Instructor CreateWithExperienceAndRating(BaseId id, FullName fullName, Biography biography, int experience, double rating);
    }
}
