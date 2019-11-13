using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ItSutra.SecondDemo.GameModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSutra.SecondDemo.GameMatches.Dto
{
    [AutoMap(typeof(Match))]
    public class MatchList : EntityDto
    {
        public TimeSpan Duration { get; set; }
        public int FirstPlayerId { get; set; }
        public int SecondPlayerId { get; set; }
        public int? WinningPlayerId { get; set; }

        public virtual Player FirstPlayer { get; set; }
        public virtual Player SecondPlayer { get; set; }
    }
}
