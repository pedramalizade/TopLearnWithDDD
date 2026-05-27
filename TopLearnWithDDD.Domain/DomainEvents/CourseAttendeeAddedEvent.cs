using TopLearnWithDDD.Domain.Entities.CourseManagement;
using TopLearnWithDDD.Shared.Abstraction.Domain;

namespace TopLearnWithDDD.Domain.DomainEvents
{
    public record CourseAttendeeAddedEvent(CourseAttendee attendde, Course course) : IDomainEvent;
}
