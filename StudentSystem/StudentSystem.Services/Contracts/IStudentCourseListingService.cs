namespace StudentSystem.Services.Contracts
{
    using System.Collections.Generic;

    using StudentSystem.Services.Models;

    internal interface IStudentCourseListingService
    {
        IEnumerable<StudentCourseListingServiceModel> GetStudentCourses(int userId);
    }
}
