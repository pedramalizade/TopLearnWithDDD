using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.User.Handlers
{
    public class DeleteUserHandler : ICommandHandler<DeleteUser>
    {
        public Task HandleAsync(DeleteUser command)
        {
            throw new NotImplementedException();
        }
    }
}
