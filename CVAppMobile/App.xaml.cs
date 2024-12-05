namespace CVAppMobile
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                var message = e.ExceptionObject as Exception;
            };
            new BusinessLogic.GlobalBusinessLogic().SetDefaultLanguage(Helpers.StaticValues.GetStaticValue(Helpers.StaticValues.DefaultLanguage, Helpers.Constants.SpanishISOCode));

            App.Current.MainPage = new NavigationPage(new Pages.TabbedPage.MainTabbedPage());
        }
    }
}
