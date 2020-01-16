namespace StudentSystem.Common
{
    using System.Collections.Generic;

    public static class CommandDictionary
    {
        public static Dictionary<string, string> NavigationCommands = new Dictionary<string, string>()
        {
            { "GoToHome", "HomeView.xaml" },
            { "GoToStudents", "StudentsView.xaml" },
            { "GoToTeachers", "TeachersView.xaml" },
            { "GoToCourses", "CoursesView.xaml" },
        };

        public static Dictionary<string, string> UserProfileCommands = new Dictionary<string, string>()
        {
            { "GoToStudentProfile", "Student/StudentProfileView.xaml" },
            { "GoToStudentCourses", "Student/StudentCoursesView.xaml" },
              
            { "GoToTeacherProfile", "Teacher/TeacherProfileView.xaml" },
            { "GoToTeacherCourses", "Teacher/TeacherCoursesView.xaml" },
              
            { "GoToAdministratorProfile", "Administrator/AdministratorProfileView.xaml" },
            { "GoToAdministratorTeachers", "Administrator/AdministratorTeachersView.xaml" },
            { "GoToAdministratorStudents", "Administrator/AdministratorStudentsView.xaml" },
            { "GoToAdministratorCourses", "Administrator/AdministratorCoursesView.xaml" },
            { "GoToAdministratorAddTeacher", "AdministratorAddTeacherView.xaml" },
            { "GoToAdministratorCourseEnrollment", "AdministratorCourseEnrollmentView.xaml" },
        };
    }
}
