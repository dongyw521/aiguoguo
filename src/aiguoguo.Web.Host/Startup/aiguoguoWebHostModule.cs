using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using aiguoguo.Configuration;

namespace aiguoguo.Web.Host.Startup
{
    [DependsOn(
       typeof(aiguoguoWebCoreModule))]
    public class aiguoguoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public aiguoguoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(aiguoguoWebHostModule).GetAssembly());
        }
    }
}
