using TopLearnWithDDD.Domain.Exceptions.UserManagementExceptions;

namespace TopLearnWithDDD.Domain.ValueObjects
{
    public record RoleName
    {
        public string Value { get; }

        public RoleName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new RoleNameNullOrEmptyException();
            }

            Value = value;
        }

        public static implicit operator string(RoleName roleName) => roleName.Value;
        public static implicit operator RoleName(string roleName) => new RoleName(roleName);
    }
}
