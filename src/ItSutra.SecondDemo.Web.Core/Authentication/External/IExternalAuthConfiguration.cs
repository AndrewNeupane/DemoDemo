using System.Collections.Generic;

namespace ItSutra.SecondDemo.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
