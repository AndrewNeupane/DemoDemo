using Abp.AutoMapper;
using ItSutra.SecondDemo.Authentication.External;

namespace ItSutra.SecondDemo.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
