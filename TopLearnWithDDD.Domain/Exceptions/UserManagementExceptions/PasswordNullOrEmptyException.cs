using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class PasswordNullOrEmptyException : UserManagementException
    {
        public PasswordNullOrEmptyException() : base("Password Can not Be Null Or Empty")
        {

        }
    }
}
