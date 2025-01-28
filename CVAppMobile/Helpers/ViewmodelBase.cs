using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CVAppMobile.Resources.Languages;

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

        #endregion

        #region Commands
        //Command que realiza navega hacia atras en la aplicación
        [RelayCommand]
        public async Task GoBack()
        {
            this.Processing = true;
            this.ProcessingMessage = LocalizedResourceManager.GetValue(nameof(AppResources.GenericLoadingIndicator));

            await this.Navigation.GoBack();

            this.Processing = false;
        }
        #endregion
    }
}
