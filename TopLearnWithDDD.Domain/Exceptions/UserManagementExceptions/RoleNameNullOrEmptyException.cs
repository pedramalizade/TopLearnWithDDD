using System;
using System.Collections.Generic;
using System.Text;
using TopLearnWithDDD.Shared.Abstraction.Exceptions;

namespace TopLearnWithDDD.Domain.Exceptions.UserManagementExceptions
{
    internal class RoleNameNullOrEmptyException : UserManagementException
    {
        public RoleNameNullOrEmptyException() : base("RoleName Can not Be Null Or Empty")
        {
            
        }
    }
}
