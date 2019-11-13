using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ItSutra.SecondDemo.GameMoves.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ItSutra.SecondDemo.GameMoves
{
    public interface IMoveService : IApplicationService
    {
        Task CreateMove(MoveItem input);
        Task<ListResultDto<MoveItem>> GetMoveList(GetAllMove input);
        Task UpdateMove(MoveItem input);
    }
}
