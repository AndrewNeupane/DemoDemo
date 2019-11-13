using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSutra.SecondDemo.GameModel
{
    public class MatchMove : FullAuditedEntity
    {
        public int MatchId { get; set; }
        public int PlayerId { get; set; }
        public int Locations { get; set; }
    }
}
