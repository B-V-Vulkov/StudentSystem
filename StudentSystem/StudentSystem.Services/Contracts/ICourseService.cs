namespace StudentSystem.Services.Contracts
{
    using System.Collections.Generic;

    using Models;

    public interface ICourseService
    {
        IEnumerable<CourseServiceModel> GetCourses();
    }
}
