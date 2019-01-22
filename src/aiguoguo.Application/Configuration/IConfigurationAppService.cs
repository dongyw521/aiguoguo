using System.Threading.Tasks;
using aiguoguo.Configuration.Dto;

namespace aiguoguo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
