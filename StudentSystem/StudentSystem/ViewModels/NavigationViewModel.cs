namespace StudentSystem.ViewModels
{
    using System;
    using Prism.Commands;

    using Common;

    public class NavigationViewModel : BaseViewModel
    {
        #region Declarations

        private string currentViewSource = ViewSource.EMPTY_VIEW_SOURCE;

        private DelegateCommand<string> changeViewCommand;

        #endregion

        #region Initializations
        #endregion

        #region Properties

        public string CurrentViewSource
        {
            get
            {
                return currentViewSource;
            }
            private set
            {
                currentViewSource = value;
                NotifyPropertyChanged();
            }
        }

        public DelegateCommand<string> ChangeViewCommand
        {
            get
            {
                if (changeViewCommand == null)
                {
                    changeViewCommand = new DelegateCommand<string>(ChangeView);
                }

                return changeViewCommand;
            }
        }

        #endregion

        #region Methods

        private void ChangeView(string view)
        {
            if (!CommandDictionary.NavigationCommands.ContainsKey(view))
            {
                throw new InvalidOperationException(ExceptionMessage.INVALID_VIEW_SOURCE_EXCEPTION);
            }

            this.CurrentViewSource = CommandDictionary.NavigationCommands[view];
        }

        #endregion
    }
}
