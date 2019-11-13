using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using ItSutra.SecondDemo.GameModel;
using ItSutra.SecondDemo.GameMoves.Dto;

namespace ItSutra.SecondDemo.GameMoves
{
    class MoveService : SecondDemoAppServiceBase, IMoveService
    {
        private readonly IRepository<MatchMove> _moveRepository;

        public MoveService(IRepository<MatchMove> moveRepository)
        {
            _moveRepository = moveRepository;
        }
        public Task CreateMove(MoveItem input)
        {
            var match = matchRepository.GetAsync(id);
            match.MatchMoves.Add(new MatchMove { PlayerId = input.PlayerId, Locations = input.Location });
            match.MatchMovies.AddRange(//list of matchmoves)


            _moveRepository.Insert(new MatchMove { })
        }

        public Task<ListResultDto<MoveItem>> GetMoveList(GetAllMove input)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMove(MoveItem input)
        {
            throw new NotImplementedException();
        }
    }
}
