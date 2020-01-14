namespace StudentSystem.ViewModels
{
    using StudentSystem.Data;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Declarations

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Initializations
        #endregion

        #region Properties
        #endregion

        #region Methods

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
