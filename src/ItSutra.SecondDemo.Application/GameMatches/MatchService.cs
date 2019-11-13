using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using ItSutra.SecondDemo.GameMatches.Dto;
using ItSutra.SecondDemo.GameModel;
using Microsoft.EntityFrameworkCore;

namespace ItSutra.SecondDemo.GameMatches
{
    public class MatchService : SecondDemoAppServiceBase, IMatchService
    {
        private readonly IRepository<Match> _matchRepository;

        public MatchService(IRepository<Match> matchRepository)
        {
            _matchRepository = matchRepository;
        }
        public async Task CreateMatch(CreateMatch input)
        {
            await _matchRepository.InsertAsync(ObjectMapper.Map<Match>(input));
        }
        public async Task<MatchResult> EndMatch(EndMatch input)
        {
            var winner = await _matchRepository.GetAsync(input.Id);
            if (input.WinningPlayerId == winner.FirstPlayerId)
            {
                winner.FirstPlayer.Win = winner.FirstPlayer.Win + 1;
                winner.FirstPlayer.Score = winner.FirstPlayer.Score + 1;

                winner.SecondPlayer.Loss = winner.SecondPlayer.Loss + 1;

                await _matchRepository.UpdateAsync(ObjectMapper.Map<Match>(winner));

            }
            if (input.WinningPlayerId == winner.SecondPlayerId)
            {
                winner.SecondPlayer.Win = winner.SecondPlayer.Win + 1;
                winner.SecondPlayer.Score = winner.SecondPlayer.Score + 1;

                winner.FirstPlayer.Loss = winner.FirstPlayer.Loss + 1;

                await _matchRepository.UpdateAsync(ObjectMapper.Map<Match>(winner));

            }
            if (input.WinningPlayerId == 0)
            {
                winner.FirstPlayer.Ties = winner.FirstPlayer.Ties + 1;
                winner.FirstPlayer.Score = winner.FirstPlayer.Score = 1 / 2;

                winner.SecondPlayer.Ties = winner.SecondPlayer.Ties + 1;
                winner.SecondPlayer.Score = winner.SecondPlayer.Score + 1 / 2;

                await _matchRepository.UpdateAsync(ObjectMapper.Map<Match>(winner));

            }
            return ObjectMapper.Map<MatchResult>(match);
        }

        public async Task<ListResultDto<MatchList>> GetMatchList(GetAllMatch input)
        {
            var matchLists = await _matchRepository
               .GetAll()
               .ToListAsync();
            return new ListResultDto<MatchList>(ObjectMapper.Map<List<MatchList>>(matchLists));
        } 
    }
}
