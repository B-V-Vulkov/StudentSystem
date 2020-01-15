namespace StudentSystem.ViewModels.UserProfiles
{
    using System;
    using Prism.Commands;

    using Common;
    using Data;
    using Services;
    using Services.Contracts;

    public class UserProfileViewModel : BaseViewModel
    {
        #region Declarations

        private IUserService userService;

        private string currentViewSource;

        private DelegateCommand<string> changeViewCommand;

        private DelegateCommand logoutCommand;

        #endregion

        #region Initializations

        public UserProfileViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public string UserFullName { get; set; }

        public UserType UserType
        {
            get
            {
                return User.UserType;
            }
        }

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

        public DelegateCommand LogoutCommand
        {
            get
            {
                if (this.logoutCommand == null)
                {
                    this.logoutCommand = new DelegateCommand(Logout);
                }

                return this.logoutCommand;
            }
        }

        #endregion

        #region Methods

        private string GetCurrentViewSource()
        {
            if (User.UserType == UserType.Student)
            {
                return ViewSource.STUDENT_PROFILE_VIEW_SOURCE;
            }
            else if (User.UserType == UserType.Teacher)
            {
                return ViewSource.TEACHER_PROFILE_VIEW_SOURCE;
            }
            else if (User.UserType == UserType.Administrator)
            {
                return ViewSource.ADMINISTRATOR_PROFILE_VIEW_SOURCE;
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessage.INVALID_USER_TYPE);
            }
        }

        private void Initialize()
        {
            this.userService = new UserService();

            this.UserFullName = userService.GetUserFullName(User.UserId);

            this.CurrentViewSource = GetCurrentViewSource();
        }

        private void ChangeView(string view)
        {
            this.CurrentViewSource = CommandDictionary.UserProfileCommands[view];
        }

        private void Logout()
        {
            User.Logout();
        }

        #endregion
    }
}
