using Mopups.Pages;
using Mopups.Services;

namespace CVAppMobile.Helpers
{
    public class CustomNavigation
    {
        public async Task GoBackToRootAsync()
        {
            await App.Current.MainPage.Navigation.PopToRootAsync();
        }

        public async Task GoBackPopModalAsync()
        {
            await App.Current.MainPage.Navigation.PopModalAsync();
        }

        public async Task GoBack()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }

        public async Task Navigate(string pageKey, params object[] parameters)
        {
            switch (pageKey)
            {
                case nameof(Pages.Home.AboutUsPage):
                    await App.Current.MainPage.Navigation.PushAsync(new Pages.Home.AboutUsPage());
                    break;
                default:
                    break;
            }
        }

        public async Task ShowMessage(string message, string cancelButton = "Ok", string title = "Alerta")
        {
            await Application.Current.MainPage.DisplayAlert(title, message, cancelButton);
        }

        public async Task ShowMessageMopup(string mopup, params object[] parameters)
        {
            switch (mopup)
            {
                //case MopupsKeys.GenericAlert:
                //    await this.ValidateShowMopup(new Mopups.GeneralMopup(parameters));
                //    break;
                //case MopupsKeys.DataBaseAlert:
                //    await this.ValidateShowMopup(new Mopups.PasswordPopup());
                //    break;
                default:
                    break;
            }
            return;
        }

        public async Task CloseMopup()
        {
            await MopupService.Instance.PopAsync();
        }

        #region Helpers
        public async Task ValidateShowMopup(PopupPage mopup)
        {
            bool canAdd = false;
            var mopupsList = MopupService.Instance.PopupStack.ToList() ?? new List<PopupPage>();
            var exists = (from lst in mopupsList where lst.GetType() == mopup.GetType() select lst).Count();
            canAdd = exists == 0;
            if (canAdd)
                await MopupService.Instance.PushAsync(mopup);
        }
        #endregion
    }

    public class MopupsKeys
    {
        public const string GenericAlert = "GenericAlertMopup";
    }
}
