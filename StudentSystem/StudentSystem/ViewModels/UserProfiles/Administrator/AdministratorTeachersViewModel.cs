namespace StudentSystem.ViewModels.UserProfiles.Administrator
{
    using Prism.Commands;
    using StudentSystem.Common;

    using static Common.CommandDictionary;
    using static Common.ViewSource;

    public class AdministratorTeachersViewModel : BaseViewModel
    {
        #region Declarations

        private string currentViewSource;

        private DelegateCommand<string> changeViewCommand;

        #endregion

        #region Initializations

        public AdministratorTeachersViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public string CurrentViewSource
        {
            get
            {
                return this.currentViewSource;
            }
            set
            {
                this.currentViewSource = value;
                NotifyPropertyChanged();
            }
        }

        public DelegateCommand<string> ChangeViewCommand
        {
            get
            {
                if (this.changeViewCommand == null)
                {
                    this.changeViewCommand = new DelegateCommand<string>(ChangeView);
                }

                return this.changeViewCommand;
            }
        }

        #endregion

        #region Methods

        private void Initialize()
        {
            this.CurrentViewSource = ADMINISTRATOR_ADD_TEACHER_VIEW_SOURCE;
        }

        private void ChangeView(string view)
        {
            this.CurrentViewSource = UserProfileCommands[view];
        }

        #endregion
    }
}
