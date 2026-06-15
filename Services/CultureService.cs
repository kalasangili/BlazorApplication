using System.Globalization;

namespace BlazorApp1.Services
{
    public class CultureService
    {
        public void SetCulture(string culture)
        {
            CultureInfo.CurrentCulture =
                new CultureInfo(culture);

            CultureInfo.CurrentUICulture =
                new CultureInfo(culture);
        }
    }
}

