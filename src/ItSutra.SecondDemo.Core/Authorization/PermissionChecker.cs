using Abp.Authorization;
using ItSutra.SecondDemo.Authorization.Roles;
using ItSutra.SecondDemo.Authorization.Users;

namespace ItSutra.SecondDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
