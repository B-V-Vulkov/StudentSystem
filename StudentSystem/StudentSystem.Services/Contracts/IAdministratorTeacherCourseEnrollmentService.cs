namespace StudentSystem.Services.Contracts
{
    using System.Collections.Generic;

    public interface IAdministratorTeacherCourseEnrollmentService
    {
        IList<string> GetTeachers();

        IList<string> GetCourses();

        void SaveCourseEnrollment(string teacherName, string courseName);
    }
}
