namespace BlazorApp1.Components.Pages.Localization.services
{
    using System.Globalization;

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
