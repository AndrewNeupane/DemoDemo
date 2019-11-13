using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSutra.SecondDemo.GameMoves.Dto
{
    public class MoveItem : EntityDto
    {
        public int MatchId { get; set; }
        public int Location { get; set; }
        public int PlayerId { get; set; }
    }
}
