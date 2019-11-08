using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ItSutra.SecondDemo.Authorization;

namespace ItSutra.SecondDemo
{
    [DependsOn(
        typeof(SecondDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SecondDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SecondDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SecondDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
