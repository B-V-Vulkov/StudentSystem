namespace StudentSystem.Common
{
    public static class ExceptionMessage
    {
        public const string INVALID_WINDOW_COMMAND_EXCEPTION =
            "The window command must be Minimize, Maximize or Close.";

        public const string INVALID_VIEW_SOURCE_EXCEPTION =
            "The view must be part of StudentSystem.Common.ViewSource.views";

        public const string INVALID_USER_TYPE =
            "The user type must be part of StudentSystem.Common.UserType";
    }
}
