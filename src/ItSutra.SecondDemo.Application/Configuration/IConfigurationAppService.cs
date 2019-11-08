using System.Threading.Tasks;
using ItSutra.SecondDemo.Configuration.Dto;

namespace ItSutra.SecondDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
