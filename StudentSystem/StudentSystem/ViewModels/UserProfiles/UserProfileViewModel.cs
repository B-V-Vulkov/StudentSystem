using StudentSystem.Common;
using System;

namespace StudentSystem.ViewModels.UserProfiles
{
    public class UserProfileViewModel : BaseViewModel
    {
        #region Declarations

        private string currentViewSource;

        #endregion

        #region Initializations

        public UserProfileViewModel()
        {
            this.CurrentViewSource = GetCurrentViewSource();
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

        public UserType UserType
        {
            get
            {
                return User.UserType;
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

            throw new InvalidOperationException(ExceptionMessage.INVALID_USER_TYPE);
        }

        #endregion
    }
}
