using CommunityToolkit.Mvvm.ComponentModel;
using CVAppMobile.Helpers;
using CVAppMobile.Resources.Languages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVAppMobile.ViewModel.Home
{
    public partial class AboutUsViewmodel : ViewmodelBase
    {
        #region Properties
        [ObservableProperty]
        ObservableCollection<Model.Custom.AttributesCustom> attributeList;
        #endregion

        #region Constructor
        public AboutUsViewmodel()
        {

        }
        #endregion

        #region Commands

        #endregion

        #region Methods
        //Método para llenar la lista de los atributos
        public void FullListOfAttributes()
        {
            ObservableCollection<Model.Custom.AttributesCustom> tmpAttributeList = new ObservableCollection<Model.Custom.AttributesCustom>()
            {
                new Model.Custom.AttributesCustom{ Description = "Trabajar en equipo" },
                new Model.Custom.AttributesCustom{ Description = "Responsabilidad en el trabajo" },
                new Model.Custom.AttributesCustom{ Description = "Respeto laboral" },
                new Model.Custom.AttributesCustom{ Description = "Puntualidad" },
                new Model.Custom.AttributesCustom{ Description = "Investigar y adquirir nuevos conocimentos" },
                new Model.Custom.AttributesCustom{ Description = "Detectar areas de oportunidad y fortalecerlas" },
                new Model.Custom.AttributesCustom{ Description = "Me gusta realizar las actividades de la mejor manera posible" },
                new Model.Custom.AttributesCustom{ Description = "Aceptar mis errores y corregir los mismos" }
            };

            this.AttributeList = tmpAttributeList;
        }
        #endregion
    }
}
