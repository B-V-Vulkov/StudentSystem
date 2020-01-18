namespace StudentSystem.Common
{
    using static GlobalConstants;
    using static DataValidations;

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

        public static string COURSE_EXISTS_EXCEPTION_MESSAGE =
            "Course named \"{0}\" already exists in the database!";

        public static string INVALID_COURSE_NAME_LENGTH_EXCEPTION_MESSAGE =
            $"Course Name must be bitween {COURSE_NAME_MIN_LENGTH} and {COURSE_NAME_MAX_LENGTH} characters!";

        public static string TEACHER_DOES_NOT_EXISTS_EXCEPTION_MESSAGE =
            "Teacher with ID {0} does not exist in the database!";

        public static string INVALID_START_DATE_EXCEPTION_MESSAGE =
            "Start date {0} is invalid! It must be in the format Day/Month/Year.";

        public static string INVALID_END_DATE_EXCEPTION_MESSAGE =
            "End date {0} is invalid! It must be in the format Day/Month/Year.";

        public static string INVALID_EXAM_DATE_EXCEPTION_MESSAGE =
            "Exam date {0} is invalid! It must be in the format Day/Month/Year.";

        public static string INVALID_USER_FIRST_NAME_LENGTH_EXCEPTION_MESSAGE =
           $"First Name must be bitween {USER_FIRST_NAME_MIN_LENGTH} and {USER_FIRST_NAME_MAX_LENGTH} characters!";

        public static string INVALID_USER_MIDDLES_NAME_LENGTH_EXCEPTION_MESSAGE =
            $"Middle Name must be bitween {USER_MIDDLE_NAME_MIN_LENGTH} and {USER_MIDDLE_NAME_MAX_LENGTH} characters!";

        public static string INVALID_USER_LAST_NAME_LENGTH_EXCEPTION_MESSAGE =
            $"Last Name must be bitween {USER_LAST_NAME_MIN_LENGTH} and {USER_LAST_NAME_MAX_LENGTH} characters!";

        public static string INVALID_TOWN_NAME_LENGTH_EXCEPTION_MESSAGE =
            $"Town Name must be bitween {TOWN_NAME_MIN_LENGTH} and {TOWN_NAME_MAX_LENGTH} characters!";

        public static string TEACHER_WAS_NOT_SELECTED_EXCEPTION_MESSAGE =
            "Please select teacher!";

        public static string COURSE_WAS_NOT_SELECTED_EXCEPTION_MESSAGE =
            "Please select course!";
    }
}
