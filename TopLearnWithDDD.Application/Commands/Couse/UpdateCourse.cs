using TopLearnWithDDD.Domain.ValueObjects;
using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.Couse
{
    public record UpdateCourse(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId) : ICommand;
}
