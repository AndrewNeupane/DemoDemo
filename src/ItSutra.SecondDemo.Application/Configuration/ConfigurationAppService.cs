using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ItSutra.SecondDemo.Configuration.Dto;

namespace ItSutra.SecondDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SecondDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
