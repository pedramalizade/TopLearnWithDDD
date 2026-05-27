using TopLearnWithDDD.Domain.Entities.UserManagement;
using TopLearnWithDDD.Domain.ValueObjects;

namespace TopLearnWithDDD.Domain.Factories.UserManagement
{
    public interface IRoleFactory
    {
        Role Create(BaseId id, RoleName roleName);
    }
}
