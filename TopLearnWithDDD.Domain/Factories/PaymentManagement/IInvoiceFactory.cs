using TopLearnWithDDD.Domain.Entities.PaymentManagement;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Factories.PaymentManagement
{
    public interface IInvoiceFactory
    {
        Invoice Create(BaseId id, Amount amount, DateTime date, BaseId userId, BaseId courseId);
    }
}
