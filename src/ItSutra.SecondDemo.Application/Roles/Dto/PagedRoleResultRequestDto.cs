using Abp.Application.Services.Dto;

namespace ItSutra.SecondDemo.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

