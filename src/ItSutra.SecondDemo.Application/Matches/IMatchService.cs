using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ItSutra.SecondDemo.Matches.Dto;
using System.Threading.Tasks;

namespace ItSutra.SecondDemo.Matches
{
    public interface IMatchService : IApplicationService
    {
        Task CreateMatch(CreateMatch input);
        Task EndMatch(EndMatch input);
        Task<ListResultDto<MatchList>> GetMatchList(GetAllMatch input);
        Task<MatchList> GetMatchById(int id);
        Task CreateMove(MovesData input);
        Task<ListResultDto<MovesData>> GetMovesByMatchId(MoveList input);
    }
}
