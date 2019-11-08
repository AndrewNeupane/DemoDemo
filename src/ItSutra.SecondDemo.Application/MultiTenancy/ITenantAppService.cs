using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ItSutra.SecondDemo.MultiTenancy.Dto;

namespace ItSutra.SecondDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

