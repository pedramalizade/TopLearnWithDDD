using TopLearnWithDDD.Domain.Factories.UserManagement;
using TopLearnWithDDD.Domain.Repositories.UserManagement;
using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.User.Handlers
{
    public class CreateUserHandler : ICommandHandler<CreateUser>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserFactory _userFactory;

        public CreateUserHandler(IUserRepository userRepository, IUserFactory userFactory)
        {
            _userRepository = userRepository;
            _userFactory = userFactory;
        }

        public async Task HandleAsync(CreateUser command)
        {
            var user = _userFactory.Create(command.id, command.userName, command.password, command.email, command.isConfirmed);
            await _userRepository.AddAsync(user);
        }
    }
}
