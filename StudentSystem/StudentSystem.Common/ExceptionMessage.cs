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
            $"Student marks must be between {MIN_STUDENT_MARK} and {MAX_STUDENT_MARK}.";

        public static string COURSE_EXISTS_EXCEPTION =
            "Course wuth name {0} already exists in database.";

        public static string TEACHER_DASNOT_EXISTS_EXCEPTION =
            "Teacher with ID {0} dasn't exists in database.";

        public static string INVALID_START_DATE_EXCEPTION =
            "Course Start Date {0} is invalid!";

        public static string INVALID_END_DATE_EXCEPTION =
            "Course End Date {0} is invalid!";

        public static string INVALID_EXAM_DATE_EXCEPTION =
            "Course Exam Date {0} is invalid!";
    }
}
