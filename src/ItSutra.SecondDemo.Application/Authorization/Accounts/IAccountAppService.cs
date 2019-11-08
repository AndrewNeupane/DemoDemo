using System.Threading.Tasks;
using Abp.Application.Services;
using ItSutra.SecondDemo.Authorization.Accounts.Dto;

namespace ItSutra.SecondDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
