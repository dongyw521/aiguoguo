using System.Threading.Tasks;
using Abp.Application.Services;
using aiguoguo.Sessions.Dto;

namespace aiguoguo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
