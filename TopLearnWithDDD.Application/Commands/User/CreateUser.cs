using TopLearnWithDDD.Domain.ValueObjects;
using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.User
{
    public record CreateUser(BaseId id, UserName userName, Password password, Email email, bool isConfirmed) : ICommand;
}