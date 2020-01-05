namespace StudentSystem.Common
{
    public static class UserState
    {
        #region Declarations

        private static bool isSignedIn = false;

        private static UserType userType = UserType.Indefinite;

        public static event NotifyUserStateChangedEventHandler UserStateChanged;

        #endregion

        #region Initializations
        #endregion

        #region Properties

        public static bool IsSignedIn
        {
            get
            {
                return isSignedIn;
            }
            private set
            {
                isSignedIn = value;
            }
        }

        public static UserType UserType
        {
            get
            {
                return userType;
            }
            private set
            {
                userType = value;
            }
        }

        #endregion

        #region Methods

        public static void SignUp()
        {
            IsSignedIn = false;
            UserStateChanged?.Invoke();
        }

        public static void SignIn(UserType type)
        {
            IsSignedIn = true;
            userType = type;
            UserStateChanged?.Invoke();
        }

        #endregion
    }
}
