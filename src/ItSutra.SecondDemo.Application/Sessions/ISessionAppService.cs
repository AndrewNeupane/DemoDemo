using System.Threading.Tasks;
using Abp.Application.Services;
using ItSutra.SecondDemo.Sessions.Dto;

namespace ItSutra.SecondDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
