using BL;
using Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListadoPersonasYDepartamentosV2.ViewModels
{
    internal class MainVM : INotifyPropertyChanged
    {
        #region Attributes
        private ObservableCollection<clsPersona> listadoPersonas;
        private ObservableCollection<clsDepartamento> listadoDepartamentos;
        private clsPersona personaSeleccionada;
        private clsDepartamento departamentoSeleccionado;
        private int countPersonas;
        #endregion

        #region Properties
        public ObservableCollection<clsPersona> ListadoPersonas
        {
            get
            {
                return listadoPersonas;
            }
        }

        public ObservableCollection<clsDepartamento> ListadoDepartamentos
        {
            get
            {
                return listadoDepartamentos;
            }
        }

        public clsPersona PersonaSeleccionada
        {
            get
            {
                return personaSeleccionada;
            }
            set
            {
                personaSeleccionada = value;
                OnPropertyChanged("PersonaSeleccionada");
            }
        }

        public clsDepartamento DepartamentoSeleccionado
        {
            get
            {
                return departamentoSeleccionado;
            }
            set
            {
                departamentoSeleccionado = value;
                listadoPersonas = new ObservableCollection<clsPersona>(clsListadosBL.getListadoPersonasPorId(departamentoSeleccionado.Id));
                OnPropertyChanged("ListadoPersonas");
            }
        }

        public int CountPersonas
        {
            get
            {
                return countPersonas;
            }
        }
        #endregion

        #region Constructors
        public MainVM()
        {
            listadoDepartamentos = new ObservableCollection<clsDepartamento>(clsListadosBL.getListadoDepartamentos());
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
