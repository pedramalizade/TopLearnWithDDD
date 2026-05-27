using TopLearnWithDDD.Domain.Primitives;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Entities.UserManagement
{
    public class Role : BaseEntity
    {
        private RoleName _roleName;
        private LinkedList<UserRole> _userRoles;

        internal Role(BaseId id, RoleName roleName) : base(id)
        {
            _roleName = roleName;   
        }

        public Role(BaseId id) : base(id)
        {
        }
    }
}
