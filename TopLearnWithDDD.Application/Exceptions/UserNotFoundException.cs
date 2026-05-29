using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Application.Exceptions
{
    public class UserNotFoundException : UserManagementException
    {
        public UserNotFoundException() : base("User Not Found...")
        {

        }
    }
}
