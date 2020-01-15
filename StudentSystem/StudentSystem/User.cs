namespace StudentSystem
{
    using Common;

    public static class User
    {
        #region Declarations

        public static event NotifyUserStateChangedEventHandler UserStateChanged;

        #endregion

        #region Initializations
        #endregion

        #region Properties

        public static bool IsLogin { get; private set; }

        public static int UserId { get; private set; }

        public static UserType UserType { get; private set; } 
            = UserType.Indefinite;

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
