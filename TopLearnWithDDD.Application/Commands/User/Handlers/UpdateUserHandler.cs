using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.User.Handlers
{
    public class UpdateUserHandler : ICommandHandler<UpdateUser>
    {
        public Task HandleAsync(UpdateUser command)
        {
            throw new NotImplementedException();
        }
    }
}
