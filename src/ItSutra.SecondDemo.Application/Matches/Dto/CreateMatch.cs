using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ItSutra.SecondDemo.GameModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSutra.SecondDemo.Matches.Dto
{
    [AutoMap(typeof(Match))]
    public class CreateMatch : EntityDto
    {
        public int FirstPlayerId { get; set; }
        public int SecondPlayerId { get; set; }
        public MatchState State { get; set; }
    }
}
