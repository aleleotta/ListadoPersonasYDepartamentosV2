using BL;
using Entities;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListadoPersonasYDepartamentosV2.ViewModels
{
    internal class MainVM : INotifyPropertyChanged
    {
        #region Attributes
        private List<clsPersona> listadoPersonas;
        private List<clsDepartamento> listadoDepartamentos;
        private clsPersona personaSeleccionada;
        private clsDepartamento departamentoSeleccionado;
        private int countPersonas;
        #endregion

        #region Properties
        public List<clsPersona> ListadoPersonas { get { return listadoPersonas; } }
        public List<clsDepartamento> ListadoDepartamentos { get { return listadoDepartamentos; } }
        public clsPersona PersonaSeleccionada { get { return personaSeleccionada; } }
        public clsDepartamento DepartamentoSeleccionado { get { return departamentoSeleccionado; } }
        public int CountPersonas { get { return countPersonas; } }
        #endregion

        #region Constructors
        public MainVM()
        {
            listadoPersonas = clsListadosBL.getListadoPersonas();
            listadoDepartamentos = clsListadosBL.getListadoDepartamentos();
        }
        #endregion

        #region Methods
        #endregion

        #region ViewModel
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}
