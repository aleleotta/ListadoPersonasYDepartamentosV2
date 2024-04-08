using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListadoPersonasYDepartamentosV2.ViewModels
{
    internal class MainVM : INotifyPropertyChanged
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructors
        public MainVM() { }
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
