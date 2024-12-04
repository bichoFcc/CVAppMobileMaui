using CVAppMobile.Resources.Languages;
using System.ComponentModel;
using System.Globalization;

namespace CVAppMobile.Helpers
{
    public class LocalizedResourceManager : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public LocalizedResourceManager()
        {
            AppResources.Culture = CultureInfo.CurrentCulture;
        }

        public static LocalizedResourceManager Instance { get; } = new();

        public object this[string resourceKey] => AppResources.ResourceManager.GetObject(resourceKey, AppResources.Culture) ?? Array.Empty<byte>();

        public static string GetValue(string resourceKey) => AppResources.ResourceManager.GetObject(resourceKey, AppResources.Culture).ToString() ?? string.Empty;

        public void SetCulture(CultureInfo culture)
        {
            AppResources.Culture = culture;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
    }
}
