using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class InvalidEmailException : UserManagementException
    {
        public InvalidEmailException() : base("Email Is Invalid")
        {

        }
    }
}
