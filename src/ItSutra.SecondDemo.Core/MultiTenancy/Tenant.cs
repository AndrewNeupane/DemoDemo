using Abp.MultiTenancy;
using ItSutra.SecondDemo.Authorization.Users;

namespace ItSutra.SecondDemo.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
