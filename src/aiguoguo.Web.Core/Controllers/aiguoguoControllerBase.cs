using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace aiguoguo.Controllers
{
    public abstract class aiguoguoControllerBase: AbpController
    {
        protected aiguoguoControllerBase()
        {
            LocalizationSourceName = aiguoguoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
