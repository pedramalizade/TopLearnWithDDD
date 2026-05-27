using TopLearnWithDDD.Domain.Exceptions.UserManagementExceptions;

namespace TopLearnWithDDD.Domain.ValueObjects
{
    public record UserName
    {
        public string Value { get; }

        public UserName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new UserNameNullOrEmptyException();
            }

            Value = value;
        }

        public static implicit operator string(UserName userName) => userName.Value;
        public static implicit operator UserName(string userName) => new UserName(userName);
    }
}
