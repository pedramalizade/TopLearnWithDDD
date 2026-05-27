using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class InvalidPasswordException : UserManagementException
    {
        public InvalidPasswordException() : base("Password id Invalid...")
        {

        }
    }
}
