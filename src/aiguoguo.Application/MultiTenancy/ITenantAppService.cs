using Abp.Application.Services;
using Abp.Application.Services.Dto;
using aiguoguo.MultiTenancy.Dto;

namespace aiguoguo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

