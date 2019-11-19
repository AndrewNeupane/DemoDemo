using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ItSutra.SecondDemo.GameModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItSutra.SecondDemo.Matches.Dto
{
    [AutoMap(typeof(Match))]
    public class EndMatch : EntityDto
    {
        [Required]
        public MatchState State { get; set; }
        [Required]
        public int WinningPlayerId { get; set; }
    }
}
