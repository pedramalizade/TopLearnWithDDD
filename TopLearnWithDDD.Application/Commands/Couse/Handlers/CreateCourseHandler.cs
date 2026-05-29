using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.Couse.Handlers
{
    public class CreateCourseHandler : ICommandHandler<CreateCourse>
    {
        public Task HandleAsync(CreateCourse command)
        {
            throw new NotImplementedException();
        }
    }
}
