using TopLearnWithDDD.Domain.DomainEvents;
using TopLearnWithDDD.Domain.ValueObjects;
using TopLearnWithDDD.Shared.Abstraction.Domain;

namespace TopLearnWithDDD.Domain.Entities.UserManagement
{
    public class User : AggregateRoot<BaseId>
    {
        private UserName _userName;
        private Password _password;
        private Email _email;
        private bool _isConfirmed;
        private LinkedList<UserRole> _userRoles;

        internal User(BaseId id, UserName userName, Password password, Email email, bool isConfirmed)
        {
            Id = id;
            _userName = userName;
            _password = password;
            _email = email;
            _isConfirmed = isConfirmed;
            RaiseDomainEvent(new UserRegisteredEvent(this));
        }

        // بخاطر بحث فکتوری ها باید بزاریم
        public User()
        {

        }
    }
}
