using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using ItSutra.SecondDemo.Authorization.Roles;
using ItSutra.SecondDemo.Authorization.Users;
using ItSutra.SecondDemo.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace ItSutra.SecondDemo.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory) 
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
