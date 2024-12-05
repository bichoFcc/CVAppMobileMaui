using CVAppMobile.Helpers;
using CVAppMobile.Resources.Languages;
using System.Globalization;

namespace CVAppMobile.BusinessLogic
{
    public class GlobalBusinessLogic
    {
        public void SwitchLanguage()
        {
            var laguageToSwitch = AppResources.Culture.TwoLetterISOLanguageName.Equals(Helpers.Constants.SpanishTwoLetterCode, StringComparison.InvariantCultureIgnoreCase) ? new CultureInfo(Helpers.Constants.EnglishISOCode) : new CultureInfo(Helpers.Constants.SpanishISOCode);
            LocalizedResourceManager.Instance.SetCulture(laguageToSwitch);
            CultureInfo.CurrentCulture = laguageToSwitch;
        }

        public void SetDefaultLanguage(string languageCode)
        {
            var laguageToSwitch = new CultureInfo(languageCode);
            LocalizedResourceManager.Instance.SetCulture(laguageToSwitch);
            CultureInfo.CurrentCulture = laguageToSwitch;
        }
    }
}
