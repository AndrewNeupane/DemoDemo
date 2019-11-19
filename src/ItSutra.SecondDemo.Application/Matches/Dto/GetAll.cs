using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSutra.SecondDemo.Matches.Dto
{
    public class GetAllMatch : EntityDto
    {
        public string Filter { get; set; }
    }
}
