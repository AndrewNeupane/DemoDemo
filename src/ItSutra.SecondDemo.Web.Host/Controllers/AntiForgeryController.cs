using Microsoft.AspNetCore.Antiforgery;
using ItSutra.SecondDemo.Controllers;

namespace ItSutra.SecondDemo.Web.Host.Controllers
{
    public class AntiForgeryController : SecondDemoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
