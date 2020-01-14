namespace StudentSystem.Services.Contracts
{
    using System.Collections.Generic;

    using Models;

    public interface ITeacherCourseService
    {
        IEnumerable<TeacherCourseServiceModel> GetTeacherCourses(int userId);

        string GetCourseName(int courseId);
    }
}
