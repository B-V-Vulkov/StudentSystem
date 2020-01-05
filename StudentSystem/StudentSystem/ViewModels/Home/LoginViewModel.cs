namespace StudentSystem.ViewModels.Home
{
    using Prism.Commands;
    using StudentSystem.Services.Services;

    public class LoginViewModel : BaseViewModel
    {
        #region Declarations

        private string userName;

        private string password;

        private DelegateCommand signInCommand;

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

        public DelegateCommand SignInCommand
        {
            get
            {
                if (this.signInCommand == null)
                {
                    this.signInCommand = new DelegateCommand(Login);
                }

                return this.signInCommand;
            }
        }

        #endregion

        #region Methods

        private void Login()
        {
            var user = service.GetUser(this.UserName, this.Password);
        }

        #endregion
    }
}
