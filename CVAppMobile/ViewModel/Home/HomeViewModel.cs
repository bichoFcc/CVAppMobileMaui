using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CVAppMobile.Helpers;
using CVAppMobile.Resources.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVAppMobile.ViewModel.Home
{
    public partial class HomeViewModel : ViewmodelBase
    {
        #region Properties

        #endregion

        #region Constructor
        public HomeViewModel() 
        {
            
        }
        #endregion

        #region Commands
        //Command que manda a la pantalla de acerca de mí
        [RelayCommand]
        private async Task SendAboutUs()
        {
            this.Processing = true;
            this.ProcessingMessage = LocalizedResourceManager.GetValue(nameof(AppResources.GenericLoadingIndicator));

            try
            {
                await this.Navigation.Navigate(nameof(Pages.Home.AboutUsPage));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar a la pantalla acerca de mí: " + ex.ToString());
            }

            this.Processing = false;
        }
        #endregion

        #region Methods
        //Método que define valores iniciales de la pantalla
        public void Initialize()
        {
            this.Processing = true;
            this.ProcessingMessage = LocalizedResourceManager.GetValue(nameof(AppResources.GenericLoadingIndicator));

            try
            {

            }
            catch (Exception ex)
            {

            }

            this.Processing = false;
        }
        #endregion
    }
}
