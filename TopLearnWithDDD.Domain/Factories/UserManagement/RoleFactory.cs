using TopLearnWithDDD.Domain.Entities.UserManagement;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Factories.UserManagement
{
    public class RoleFactory : IRoleFactory
    {
        public Role Create(BaseId id, RoleName roleName)
        {
            return new Role(id, roleName);
        }
    }
}
