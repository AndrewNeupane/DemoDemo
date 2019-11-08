using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ItSutra.SecondDemo.Configuration;

namespace ItSutra.SecondDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(SecondDemoWebCoreModule))]
    public class SecondDemoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SecondDemoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SecondDemoWebHostModule).GetAssembly());
        }
    }
}
