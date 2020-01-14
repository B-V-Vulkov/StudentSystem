namespace StudentSystem.Services.Contracts
{
    using System.Collections.Generic;

    using Models;

    public interface IStudentCourseService
    {
        IEnumerable<StudentCourseServiceModel> GetStudentCourses(int userId);
    }
}
