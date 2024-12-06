using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Mopups.Hosting;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace CVAppMobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseSkiaSharp()
                .ConfigureMopups()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            #region Generic instances
            builder.Services.AddSingleton<Helpers.CustomNavigation>();
            #endregion

            #region Business Logic
            builder.Services.AddSingleton<BusinessLogic.GlobalBusinessLogic>();
            #endregion

            #region Viewmodels
            builder.Services.AddSingleton<ViewModel.Home.HomeViewModel>();
            builder.Services.AddSingleton<ViewModel.Experience.ExperienceViewModel>();
            builder.Services.AddSingleton<ViewModel.Skills.SkillsViewModel>();
            builder.Services.AddSingleton<ViewModel.Projects.ProjectsViewModel>();
            #endregion

            #region ViewModels Popup
            builder.Services.AddSingleton<ViewModel.Mopup.MopupViewModel>();
            #endregion

            var app = builder.Build();

            var navigation = app.Services.GetService<Helpers.CustomNavigation>();
            if (navigation != null)
                Helpers.GlobalValues.GlobalNavigation = navigation;

            App.ServiceProvider = app.Services;

            return builder.Build();
        }
    }
}
