using CVAppMobile.Helpers;
using CVAppMobile.Resources.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVAppMobile.ViewModel.Skills
{
    public partial class SkillsViewModel : ViewmodelBase
    {
        #region Properties

        #endregion

        #region Constructor
        public SkillsViewModel() 
        {

        }
        #endregion

        #region Commands

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
