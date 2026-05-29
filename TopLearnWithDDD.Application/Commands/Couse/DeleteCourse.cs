using TopLearnWithDDD.Domain.ValueObjects;
using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.Couse
{
    public record DeleteCourse(BaseId id) : ICommand;
}
