using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ItSutra.SecondDemo.Authorization;
using ItSutra.SecondDemo.Authorization.Roles;
using ItSutra.SecondDemo.Authorization.Users;
using ItSutra.SecondDemo.Editions;
using ItSutra.SecondDemo.MultiTenancy;

namespace ItSutra.SecondDemo.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
