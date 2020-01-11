﻿namespace StudentSystem.ViewModels
{
    using Prism.Commands;
    using StudentSystem.Common;

    using StudentSystem.Services.Services;

    public class LoginViewModel : BaseViewModel
    {
        #region Declarations

        private string userName;

        private string password;

        private DelegateCommand loginCommand;

        private UserService service;

        #endregion

        #region Initializations

        public LoginViewModel()
        {
            this.service = new UserService();
        }

        #endregion

        #region Properties

        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
                NotifyPropertyChanged();
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
                NotifyPropertyChanged();
            }
        }

        public DelegateCommand LoginCommand
        {
            get
            {
                if (this.loginCommand == null)
                {
                    this.loginCommand = new DelegateCommand(ValidateUser);
                }

                return this.loginCommand;
            }
        }

        #endregion

        #region Methods

        private void ValidateUser()
        {
            //TODO: GetUser in UserService
            User.Login(3, UserType.Teacher);
        }

        #endregion
    }
}
