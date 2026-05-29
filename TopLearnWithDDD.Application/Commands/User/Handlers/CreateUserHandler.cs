using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.User.Handlers
{
    public class CreateUserHandler : ICommandHandler<CreateUser>
    {
        public Task HandleAsync(CreateUser command)
        {
            throw new NotImplementedException();
        }
    }
}
