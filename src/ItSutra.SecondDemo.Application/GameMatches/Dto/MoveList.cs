using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSutra.SecondDemo.GameMatches.Dto
{
    public class MoveList : EntityDto
    {
        public int MatchId { get; set; }
        public int Location { get; set; }
    }
}
