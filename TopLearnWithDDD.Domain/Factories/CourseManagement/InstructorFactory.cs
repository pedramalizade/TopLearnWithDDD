using TopLearnWithDDD.Domain.Entities.CourseManagement;
using TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Factories.CourseManagement
{
    public class InstructorFactory : IInstructorFactory
    {
        public Instructor CreateWithoutExperienceAndRating(BaseId id, FullName fullName, Biography biography)
        {
            return new Instructor(id, fullName, biography);
        }

        public Instructor CreateWithExperienceAndWithoutRating(BaseId id, FullName fullName, Biography biography, int experience)
        {
            if(experience < 3)
            {
                throw new InvalidInstructorExperienceException();
            }

            return new Instructor(id, fullName, biography, experience);
        }

        public Instructor CreateWithExperienceAndRating(BaseId id, FullName fullName, Biography biography, int experience, double rating)
        {
            if(experience < 3)
            {
                throw new InvalidInstructorExperienceException();
            }

            if(rating < 0)
            {
                throw new InvalidInstructorRatingException();
            }

            return new Instructor(id, fullName, biography, experience, rating);
        }
    }
}
