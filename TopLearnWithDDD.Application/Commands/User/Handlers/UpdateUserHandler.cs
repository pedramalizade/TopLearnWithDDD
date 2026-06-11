using TopLearnWithDDD.Application.Exceptions;
using TopLearnWithDDD.Domain.Factories.UserManagement;
using TopLearnWithDDD.Domain.Repositories.UserManagement;
using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.User.Handlers
{
    public class UpdateUserHandler : ICommandHandler<UpdateUser>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserFactory _userFactory;

        public UpdateUserHandler(IUserRepository userRepository, IUserFactory userFactory)
        {
            _userRepository = userRepository;
            _userFactory = userFactory;
        }

        public async Task HandleAsync(UpdateUser command)
        {
            var user = await _userRepository.GetAsync(command.id);
            if (user == null)
            {
                throw new UserNotFoundException();
            }

            user = _userFactory.Create(user.Id, command.userName, command.password, command.email, command.isConfirmed);
            await _userRepository.UpdateAsync(user);
        }
    }
}
