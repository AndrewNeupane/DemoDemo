using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ItSutra.SecondDemo.Roles.Dto;
using ItSutra.SecondDemo.Users.Dto;

namespace ItSutra.SecondDemo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
