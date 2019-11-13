using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItSutra.SecondDemo.GameModel
{
    public class Player : FullAuditedEntity, ISoftDelete
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Phone]
        [Required]
        public int PhoneNumber { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        // convert string to DateTime
        public string DateOfBirth { get; set; }
        public int Win { get; set; }
        public int Loss { get; set; }
        public int Ties { get; set; }
        public double Score { get; set; }
    }
}
