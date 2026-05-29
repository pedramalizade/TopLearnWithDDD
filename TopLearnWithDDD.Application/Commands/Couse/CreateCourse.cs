using System.Buffers.Text;
using TopLearnWithDDD.Domain.ValueObjects;
using TopLearnWithDDD.Shared.Abstraction.Commands;
using static System.Net.WebRequestMethods;

namespace TopLearnWithDDD.Application.Commands.Couse
{
    public record CreateCourse(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId) : ICommand;
}
