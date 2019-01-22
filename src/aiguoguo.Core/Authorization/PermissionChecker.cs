using Abp.Authorization;
using aiguoguo.Authorization.Roles;
using aiguoguo.Authorization.Users;

namespace aiguoguo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
