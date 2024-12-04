using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CVAppMobile.Helpers
{
    public partial class ViewmodelBase : ObservableObject
    {
        #region Constructor
        public CustomNavigation Navigation => Helpers.GlobalValues.GlobalNavigation;

        public ViewmodelBase()
        {

        }
        #endregion

        #region Global properties
        [ObservableProperty]
        string userRole;

        [ObservableProperty]
        string userFullName;

        [ObservableProperty]
        string userName;

        [ObservableProperty]
        string userInitials;

        [ObservableProperty]
        string currentEnvironment;

        [ObservableProperty]
        bool isOperationalUser;

        [ObservableProperty]
        string pageTitle;

        [ObservableProperty]
        string syncProgress;

        [ObservableProperty]
        string processingMessage;

        [ObservableProperty]
        bool processing;

        [ObservableProperty]
        bool hasValidSession;

        [ObservableProperty]
        string version;

        [ObservableProperty]
        bool visibleSQLite;
        #endregion

        #region Methods
        //Método que valida el token
        public async Task ValidateToken(string newToken, string newEnvironment)
        {
            try
            {
                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                JwtSecurityToken jsonToken = handler.ReadToken(newToken) as JwtSecurityToken;
                if (jsonToken != null)
                    GlobalValues.TokenValues = new(newToken, newEnvironment, jsonToken.Claims.ToList());

                var currentToken = StaticValues.GetStaticValue<string>(StaticValues.SuiteToken);
                if (string.IsNullOrEmpty(currentToken))
                {
                    UpdateOrCleanPrefrences(ActionsInPreferences.UpdatePreferences);
                    App.Current.MainPage = new Pages.ProgrammingLoad.ProgrammingLoadPage();
                    return;
                }

                var currentEnvironment = StaticValues.GetStaticValue<string>(StaticValues.CurrentEnvironment);
                var currentEmail = StaticValues.GetStaticValue<string>(StaticValues.UserEmail);
                if (GlobalValues.TokenValues.Environment != currentEnvironment || GlobalValues.TokenValues.UserMail != currentEmail)
                {
                    var cleanDatabase = await GlobalValues.HunterRepository.CleanDatabase();
                    UpdateOrCleanPrefrences(ActionsInPreferences.CleanPreferences);
                    UpdateOrCleanPrefrences(ActionsInPreferences.UpdatePreferences);
                    App.Current.MainPage = new Pages.ProgrammingLoad.ProgrammingLoadPage();
                    return;
                }

                var currentDate = Convert.ToDateTime(StaticValues.GetStaticValue<string>(StaticValues.SuiteEndTokenValidity));
                if (currentDate < DateTime.Now)
                {
                    if (GlobalValues.TokenValues.SessionEndValidity > currentDate)
                        UpdateOrCleanPrefrences(ActionsInPreferences.UpdatePreferences);
                    else
                        OSystem.OpenSuite(AppInfo.PackageName);
                }

                //if (StaticValues.GetStaticValue<bool>(StaticValues.UserSession))
                //    App.Current.MainPage = new NavigationPage(new Pages.TabbedPage.MainTabbedPage());
                //else
                //    App.Current.MainPage = new Pages.ProgrammingLoad.ProgrammingLoadPage();
            }
            catch (Exception ex)
            {
                OSystem.OpenSuite(AppInfo.PackageName);
            }
        }

        //Método que actualiza o limpia las preferencias
        private void UpdateOrCleanPrefrences(ActionsInPreferences actions)
        {
            if (actions == ActionsInPreferences.UpdatePreferences)
            {
                StaticValues.SetStaticValue(StaticValues.SuiteToken, GlobalValues.TokenValues.Token);
                StaticValues.SetStaticValue(StaticValues.CurrentEnvironment, GlobalValues.TokenValues.Environment);
                StaticValues.SetStaticValue(StaticValues.UserName, GlobalValues.TokenValues.UserFullName);
                StaticValues.SetStaticValue(StaticValues.UserEmail, GlobalValues.TokenValues.UserMail);
                StaticValues.SetStaticValue(StaticValues.SuiteEndTokenValidity, GlobalValues.TokenValues.SessionEndValidity.ToString());
            }
            else
                StaticValues.ClearStaticValues();
        }
        #endregion
    }
}
