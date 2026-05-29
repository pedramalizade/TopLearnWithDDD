using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.Couse.Handlers
{
    public class DeleteCourseHandler : ICommandHandler<DeleteCourse>
    {
        public Task HandleAsync(DeleteCourse command)
        {
            throw new NotImplementedException();
        }
    }
}
