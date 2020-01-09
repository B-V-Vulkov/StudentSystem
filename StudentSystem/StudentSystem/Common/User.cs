namespace StudentSystem.Common
{
    public static class User
    {
        #region Declarations

        private static bool isLogin = false;

        private static int userId = 0;

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

        public static int UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
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
            UserType = UserType.Indefinite;
            UserId = 0;

            UserStateChanged?.Invoke();
        }

        public static void Login(int userId, UserType type)
        {
            IsLogin = true;
            UserType = type;
            UserId = userId;

            UserStateChanged?.Invoke();
        }

        #endregion
    }
}
