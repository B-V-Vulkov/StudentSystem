namespace StudentSystem.Common
{
    public static class User
    {
        #region Declarations

        private static bool isLogin = false;

        private static UserType userType = UserType.Indefinite;

        public static event NotifyUserStateChangedEventHandler UserStateChanged;

        #endregion

        #region Initializations
        #endregion

        #region Properties

        public static bool IsLogin
        {
            get
            {
                return isLogin;
            }
            private set
            {
                isLogin = value;
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

        public static void Logout()
        {
            IsLogin = false;
            UserStateChanged?.Invoke();
        }

        public static void Login(UserType type)
        {
            IsLogin = true;
            userType = type;
            UserStateChanged?.Invoke();
        }

        #endregion
    }
}
