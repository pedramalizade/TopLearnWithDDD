using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.PaymentManagementexceptions
{
    internal class InvalidAmountException : PaymentManagementException
    {
        public InvalidAmountException() : base("Amount Can Not Be Negative")
        {
            
        }
    }
}
