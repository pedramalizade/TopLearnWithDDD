using TopLearnWithDDD.Domain.Exceptions.CourseManagementExceptions;

namespace TopLearnWithDDD.Domain.ValueObjects
{
    public record Price
    {
        public decimal Value { get; }

        public Price(decimal value)
        {
            if (value < 0)
            {
                throw new InvalidPriceException();
            }

            Value = value;
        }

        public static implicit operator decimal(Price price) => price.Value;
        public static implicit operator Price(decimal price) => new Price(price);
    }
}
