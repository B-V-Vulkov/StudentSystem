namespace StudentSystem.ViewModels.Home
{
    using Prism.Commands;

    public class SignInViewModel : BaseViewModel
    {
        #region Declarations

        private string userName;

        private string password;

        private DelegateCommand signInCommand;

        #endregion

        #region Initializations
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
                    this.signInCommand = new DelegateCommand(SignIn);
                }

                return this.signInCommand;
            }
        }

        #endregion

        #region Methods

        //TODO
        private void SignIn()
        {
        }

        #endregion
    }
}
