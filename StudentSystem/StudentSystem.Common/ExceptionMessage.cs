namespace StudentSystem.Common
{
    using static GlobalConstants;

    public static class ExceptionMessage
    {
        public static string INVALID_WINDOW_COMMAND_EXCEPTION =
            "The window command must be Minimize, Maximize or Close.";

        public static string INVALID_VIEW_SOURCE_EXCEPTION =
            "The view must be part of StudentSystem.Common.ViewSource.views";

        public static string INVALID_USER_TYPE =
            "The user type must be part of StudentSystem.Common.UserType";

        public static string INVALID_STUDENT_MARK =
            $"The student mark must be between {MIN_STUDENT_MARK} and {MAX_STUDENT_MARK}.";
    }
}
