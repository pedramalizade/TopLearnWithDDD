using TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions;

namespace TopLearnWithDDD.Domain.ValueObjects
{
    public record FullName
    {
        public string Value { get; }

        public FullName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new FullNameNullOrEmptyException();
            }

            if (value.Length > 30)
            {
                throw new InvalidFullNameLengthException(30);
            }

            Value = value;
        }

        public static implicit operator string(FullName fullName) => fullName.Value;
        public static implicit operator FullName(string FullName) => new FullName(FullName);
    }
}
