using TopLearnWithDDD.Domain.Entities.UserManagement;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Factories.UserManagement
{
    public interface IUserFactory
    {
        User Create(BaseId id, UserName userName, Password password, Email email, bool isConfirmed);
    }
}
