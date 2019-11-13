using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ItSutra.SecondDemo.Game.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ItSutra.SecondDemo.Game
{
    public interface IPlayerService : IApplicationService
    {
        Task<ListResultDto<PlayerListItem>> GetAllPlayer(GetPlayerInput input);
        //Task<ListResultDto<PlayerListItem>> GetAllPlayer();
        Task CreatePlayer(PlayerListItem input);
        Task DeletePlayer(int id);
        Task UpdatePlayer(PlayerListItem input);
        Task<PlayerListItem> GetPlayerById(int id);
    }
}
