using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ItSutra.SecondDemo.GameModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSutra.SecondDemo.Matches.Dto
{
    [AutoMap(typeof(MatchMove))]
    public class MovesData : EntityDto
    {
        public int MatchId { get; set; }
        public int Location { get; set; }
        public int PlayerId { get; set; }
    }
}
