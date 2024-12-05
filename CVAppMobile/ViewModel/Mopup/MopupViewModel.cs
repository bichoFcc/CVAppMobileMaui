using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CVAppMobile.Helpers;
using CVAppMobile.Resources.Languages;

namespace CVAppMobile.ViewModel.Mopup
{
    public partial class MopupViewModel : ViewmodelBase
    {
        #region Properties
        [ObservableProperty]
        string genericText;
        #endregion

        #region Constructor
        public MopupViewModel()
        {

        }
        #endregion

        #region Commands
        //Command para cerrar el modal
        [RelayCommand]
        private async Task Cancel()
        {
            this.Processing = true;
            this.ProcessingMessage = LocalizedResourceManager.GetValue(nameof(AppResources.GenericLoadingIndicator));

            try
            {
                await GlobalValues.GlobalNavigation.CloseMopup();
            }
            catch (Exception ex)
            {
                Console.WriteLine("MopupViewModel --> Cancel: " + ex.Message);
            }

            this.Processing = false;
        }
        #endregion

        #region Methods
        
        #endregion
    }
}
