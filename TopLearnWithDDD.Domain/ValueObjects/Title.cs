using TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions;

namespace TopLearnWithDDD.Domain.ValueObjects
{
    public record Title
    {
        public string Value { get; }

        public Title(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new TitleNullOrEmptyException();
            }

            if (value.Length > 50)
            {
                throw new InvalidTitleLengthException(50);
            }

            Value = value;
        }

        public static implicit operator string(Title title) => title.Value;
        public static implicit operator Title(string title) => new Title(title);
    }
}
