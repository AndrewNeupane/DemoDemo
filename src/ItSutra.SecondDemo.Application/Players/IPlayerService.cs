using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ItSutra.SecondDemo.Players.Dto;
using System.Threading.Tasks;

namespace ItSutra.SecondDemo.Players
{
    public interface IPlayerService : IApplicationService
    {
        Task<ListResultDto<PlayerListItem>> GetAllPlayer(GetPlayerInput input);
        //Task<ListResultDto<PlayerListItem>> GetAllPlayer();
        Task CreatePlayer(PlayerListItem input);
        Task DeletePlayer(int id);
        Task UpdatePlayer(PlayerListItem input);
        Task<PlayerListItem> GetPlayerById(int id);
        Task<ListResultDto<ScoreList>> GetAllScore();
    }
}
