using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Controllers
{
    [Route("Culture")]
    public class LocalizeController : Controller
    {
        [Route("Set")]
        public IActionResult Set(string culture)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(
                    new RequestCulture(culture))
                );

            return Redirect("/greetingApp");
        }  
    }
}



