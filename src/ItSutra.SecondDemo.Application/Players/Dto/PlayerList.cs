using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ItSutra.SecondDemo.GameModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ItSutra.SecondDemo.Players.Dto
{
    [AutoMap(typeof(Player))]
    public class PlayerListItem : EntityDto
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Phone] [Required]
        public string PhoneNumber { get; set; }
        [EmailAddress] [Required]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
