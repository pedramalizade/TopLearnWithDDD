using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class UserNameNullOrEmptyException : UserManagementException
    {
        public UserNameNullOrEmptyException() : base("UserName Can Not Be Null Or Empty")
        {

        }
    }
}
