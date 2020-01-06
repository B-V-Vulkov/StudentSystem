namespace StudentSystem.ViewModels.Home
{
    using StudentSystem.Common;

    public class HomeViewModel : BaseViewModel
    {
        #region Declarations

        private string currentViewSource;

        #endregion

        #region Initializations

        public HomeViewModel()
        {
            this.CurrentViewSource = GetCurrentViewSource();
            User.UserStateChanged += RefreshView;
        }

        #endregion

        #region Properties

        public string CurrentViewSource
        {
            get
            {
                return this.currentViewSource;
            }
            private set
            {
                this.currentViewSource = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        #region Methods

        private void RefreshView()
        {
            CurrentViewSource = GetCurrentViewSource();
        }

        private string GetCurrentViewSource()
        {
            if (!User.IsLogin)
            {
                return ViewSource.LOGIN_VIEW_SOURCE;
            }

            string source = string.Empty;

            if (User.UserType == UserType.Student)
            {
                source = ViewSource.STUDENT_PROFILE_VIEW_SOURCE;
            }

            return source;
        }

        #endregion

    }
}
