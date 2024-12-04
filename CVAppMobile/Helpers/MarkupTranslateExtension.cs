namespace CVAppMobile.Helpers
{
    [ContentProperty(nameof(Name))]
    public class MarkupTranslateExtension : IMarkupExtension<BindingBase>
    {
        public string Name { get; set; }

        public BindingBase ProvideValue(IServiceProvider serviceProvider)
        {
            return new Binding { Mode = BindingMode.OneWay, Path = $"[{Name}]", Source = LocalizedResourceManager.Instance };
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }

        string GetTranslatedResource(string resourceName)
        {
            string value = string.Empty;
            try
            {
                value = LocalizedResourceManager.Instance[resourceName].ToString();
            }
            catch
            {
                value = string.Empty;
            }
            return value;
        }
    }
}
