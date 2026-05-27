using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class EmailNullOrEmptyException : UserManagementException
    {
        public EmailNullOrEmptyException() : base("Email Can Not Be Empty")
        {

        }
    }
}
