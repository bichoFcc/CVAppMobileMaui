namespace CVAppMobile.Helpers
{
    public class StaticValues
    {
        public const string DefaultLanguage = "APPLANGUAGE";

        public static void SetStaticValue(string key, string value)
        {
            Preferences.Remove(key);
            Preferences.Set(key, value);
        }

        public static void SetStaticValue(string key, double value)
        {
            Preferences.Remove(key);
            Preferences.Set(key, value);
        }

        public static void SetStaticValue(string key, int value)
        {
            Preferences.Remove(key);
            Preferences.Set(key, value);
        }

        public static void SetStaticValue(string key, bool value)
        {
            Preferences.Remove(key);
            Preferences.Set(key, value);
        }

        public static void SetStaticValue(string key, DateTime value)
        {
            Preferences.Remove(key);
            Preferences.Set(key, value);
        }

        public static T GetStaticValue<T>(string key)
        {
            var staticValue = default(T);
            try
            {
                if (Preferences.Default.ContainsKey(key))
                {
                    staticValue = Preferences.Default.Get(key, default(T));
                }
            }
            catch (Exception)
            {
                staticValue = default(T);
            }
            return staticValue;
        }

        public static T GetStaticValue<T>(string key, T defaultValue)
        {
            var staticValue = defaultValue;
            try
            {
                if (Preferences.Default.ContainsKey(key))
                {
                    staticValue = Preferences.Default.Get(key, default(T));
                }
            }
            catch (Exception)
            {
                staticValue = defaultValue;
            }
            return staticValue;
        }

        public static void ClearStaticValues()
        {
            Preferences.Remove(DefaultLanguage);
        }
    }

    public class GlobalValues
    {
        public static CustomNavigation GlobalNavigation { get; set; }
    }
}
