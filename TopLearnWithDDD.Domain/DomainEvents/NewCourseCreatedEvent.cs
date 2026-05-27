using TopLearnWithDDD.Domain.Entities.CourseManagement;
using TopLearnWithDDD.Shared.Abstraction.Domain;

namespace TopLearnWithDDD.Domain.DomainEvents
{
    public record NewCourseCreatedEvent(Course courses) : IDomainEvent;
}
