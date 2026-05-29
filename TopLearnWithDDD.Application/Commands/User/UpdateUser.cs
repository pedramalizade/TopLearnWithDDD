using TopLearnWithDDD.Domain.ValueObjects;
using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.User
{
    public record UpdateUser(BaseId id, UserName userName, Password password, Email email, bool isConfirmed) : ICommand;
}