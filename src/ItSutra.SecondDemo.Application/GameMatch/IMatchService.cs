using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ItSutra.SecondDemo.GameModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ItSutra.SecondDemo.GameMatch
{
    public interface IMatchService : IApplicationService
    {
        Task<Match> CreateMatch(Match Entity);
        Task<ListResultDto<Match>> GetMatchList(EntityDto input);
        Task<Player> GetPlayerInfo(EntityDto input);
    }
}
