using System.ComponentModel.DataAnnotations;

namespace ItSutra.SecondDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}