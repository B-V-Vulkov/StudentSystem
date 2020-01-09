namespace StudentSystem.Common
{
    using System.Collections.Generic;

    public static class CommandDictionary
    {
        public static Dictionary<string, string> NavigationCommands = new Dictionary<string, string>()
        {
            {"GoToHome", "HomeView.xaml" },
            {"GoToStudents", "StudentsView.xaml" },
        };

        public static Dictionary<string, string> UserProfileCommands = new Dictionary<string, string>()
        {
            {"GoToStudentProfile", "Student/StudentProfileView.xaml" },
            {"GoToStudentCourses", "Student/StudentCoursesView.xaml" },

            {"GoToTeacherProfile", "Teacher/TeacherProfileView.xaml" },
            {"GoToTeacherCourses", "Teacher/TeacherCoursesView.xaml" },

            {"GoToAdministratorProfile", "Student/StudentProfileView.xaml" },
            {"GoToAdministrator", "Student/StudentCoursesView.xaml" },
        };
    }
}
