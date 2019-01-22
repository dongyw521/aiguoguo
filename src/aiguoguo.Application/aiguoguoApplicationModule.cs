using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using aiguoguo.Authorization;

namespace aiguoguo
{
    [DependsOn(
        typeof(aiguoguoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class aiguoguoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<aiguoguoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(aiguoguoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
