using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ItSutra.SecondDemo.Controllers
{
    public abstract class SecondDemoControllerBase: AbpController
    {
        protected SecondDemoControllerBase()
        {
            LocalizationSourceName = SecondDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
