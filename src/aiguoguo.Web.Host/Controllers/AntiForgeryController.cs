using Microsoft.AspNetCore.Antiforgery;
using aiguoguo.Controllers;

namespace aiguoguo.Web.Host.Controllers
{
    public class AntiForgeryController : aiguoguoControllerBase
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
