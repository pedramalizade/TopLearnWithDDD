using TopLearnWithDDD.Domain.Entities.UserManagement;
using TopLearnWithDDD.Shared.Abstraction.Domain;

namespace TopLearnWithDDD.Domain.DomainEvents
{
    public record UserRegisteredEvent(User user) : IDomainEvent;
}
