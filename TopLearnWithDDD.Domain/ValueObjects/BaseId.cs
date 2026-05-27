using TopLearnWithDDD.Domain.Exceptions;

namespace TopLearnWithDDD.Domain.ValueObjects
{
    public record BaseId
    {
        public Guid Value { get; }
        
        public BaseId(Guid value)
        {
            if(value == Guid.Empty)
            {
                throw new BaseIdNullException();
            }

            Value = value;
        }

        //حالا چرا اینکار رو میکنیم؟
        // تا هرکسی نیاد این رو صدا بکنه

        // اون مقدار رو به بیرون پاس میده
        public static implicit operator Guid(BaseId id) => id.Value;
        // وقتی میخوایم new کنیم از این استفاده کنیم
        public static implicit operator BaseId(Guid id) => new BaseId(id);
    }
}
