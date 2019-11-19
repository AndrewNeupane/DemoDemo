using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSutra.SecondDemo.Players.Dto
{
    public class ScoreList : EntityDto
    {
        public string FirstName { get; set; }
        public int Win { get; set; }
        public int Loss { get; set; }
        public int Ties { get; set; }
        public double Score { get; set; }
    }
}
