using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using aiguoguo.Configuration.Dto;

namespace aiguoguo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : aiguoguoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
