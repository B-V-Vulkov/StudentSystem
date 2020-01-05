namespace StudentSystem.Common
{
    using System.Collections.Generic;

    public static class ViewSource
    {
        public const string EMPTY_VIEW_SOURCE = "../EmptyView.xaml";

        public const string LOGIN_VIEW_SOURCE = "../Home/LoginView.xaml";

        public const string TEACHER_PROFILE_VIEW_SOURCE = "TeacherProfileView.xaml";

        public const string HOME_VIEW = "HomeView";

        public static Dictionary<string, string> views = new Dictionary<string, string>()
        {
            {"HomeView", "../Home/HomeView.xaml" },
            {"StudentsView", "../Students/StudentsView.xaml" },
            {"TeachersView", "../Teachers/TeachersView.xaml" },
            {"CoursesView", "../Courses/CoursesView.xaml" },
        };
    }
}
