using TopLearnWithDDD.Domain.Entities.UserManagement;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Factories.UserManagement
{
    public class UserFactory : IUserFactory
    {
        public User Create(BaseId id, UserName userName, Password password, Email email, bool isConfirmed)
        {
            return new User(id, userName, password, email, isConfirmed);
        }
    }
}
