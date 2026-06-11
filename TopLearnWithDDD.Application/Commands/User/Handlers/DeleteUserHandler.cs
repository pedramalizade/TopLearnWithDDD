using TopLearnWithDDD.Application.Exceptions;
using TopLearnWithDDD.Domain.Repositories.UserManagement;
using TopLearnWithDDD.Shared.Abstraction.Commands;

namespace TopLearnWithDDD.Application.Commands.User.Handlers
{
    public class DeleteUserHandler : ICommandHandler<DeleteUser>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task HandleAsync(DeleteUser command)
        {
            var user = await _userRepository.GetAsync(command.id);
            if (user == null)
            {
                throw new UserNotFoundException();
            }

            await _userRepository.DeleteAsync(user);
        }
    }
}
