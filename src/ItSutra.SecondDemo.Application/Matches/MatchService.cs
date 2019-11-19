using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.UI;
using ItSutra.SecondDemo.Matches.Dto;
using ItSutra.SecondDemo.GameModel;
using Microsoft.EntityFrameworkCore;

namespace ItSutra.SecondDemo.Matches
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

        public async Task CreateMove(MovesData input)
        {
            var match = await _matchRepository.GetAsync(input.MatchId);
            if(input.PlayerId != match.FirstPlayerId || input.PlayerId != match.SecondPlayerId)
                throw new UserFriendlyException("Not a Valid Player");
            
            match.MatchMoves.Add(new MatchMove { PlayerId = input.PlayerId, Location = input.Location });

        }

        public async Task EndMatch(EndMatch input)
        {
            var match = await _matchRepository.GetAsync(input.Id);
            if(input.WinningPlayerId == match.FirstPlayerId)
            {
                match.FirstPlayer.Win = match.FirstPlayer.Win + 1;
                match.FirstPlayer.Score = match.FirstPlayer.Score + 1;
                match.SecondPlayer.Loss = match.SecondPlayer.Loss + 1;
                match.WinningPlayerId = match.FirstPlayerId;
            }
            if(input.WinningPlayerId == match.SecondPlayerId)
            {
                match.SecondPlayer.Win = match.SecondPlayer.Win + 1;
                match.SecondPlayer.Score = match.SecondPlayer.Score + 1;
                match.FirstPlayer.Loss = match.FirstPlayer.Loss + 1;
                match.WinningPlayerId = match.SecondPlayerId;
            }
            if(input.WinningPlayerId == 0)
            {
                match.FirstPlayer.Ties = match.FirstPlayer.Ties + 1;
                match.FirstPlayer.Score = match.FirstPlayer.Score + 0.5;
                match.SecondPlayer.Ties = match.SecondPlayer.Ties + 1;
                match.SecondPlayer.Score = match.SecondPlayer.Score + 0.5;
            }
        }

        public async Task<MatchList> GetMatchById(int id) => ObjectMapper.Map<MatchList>(await _matchRepository.GetAsync(id));

         
        public async Task<ListResultDto<MatchList>> GetMatchList(GetAllMatch input)
        {
            var matchLists = await _matchRepository
               .GetAll()
               .ToListAsync();
            return new ListResultDto<MatchList>(ObjectMapper.Map<List<MatchList>>(matchLists));
        }

        public async Task<ListResultDto<MovesData>> GetMovesByMatchId(MoveList input)
        {
            var match = await _matchRepository.GetAsync(input.MatchId);
            return new ListResultDto<MovesData>(ObjectMapper.Map<List<MovesData>>(match.MatchMoves));
        }
    }
}
