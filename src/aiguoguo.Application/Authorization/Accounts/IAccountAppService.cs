using System.Threading.Tasks;
using Abp.Application.Services;
using aiguoguo.Authorization.Accounts.Dto;

namespace aiguoguo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
