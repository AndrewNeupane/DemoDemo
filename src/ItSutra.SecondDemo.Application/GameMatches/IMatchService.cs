using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ItSutra.SecondDemo.GameMatches.Dto;
using ItSutra.SecondDemo.GameModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ItSutra.SecondDemo.GameMatches
{
    public interface IMatchService : IApplicationService
    {
        Task CreateMatch(CreateMatch input);
        Task<MatchResult> EndMatch(EndMatch input);
        Task<ListResultDto<MatchList>> GetMatchList(GetAllMatch input);
    }
}
