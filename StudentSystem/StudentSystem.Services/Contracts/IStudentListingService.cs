namespace StudentSystem.Services.Contracts
{
    using System.Collections.Generic;

    using StudentSystem.Services.Models;
    
    internal interface IStudentListingService
    {
        IEnumerable<StudentCourseListingServiceModel> GetStudents();
    }
}
