namespace StudentSystem.Services.Contracts
{
    using System.Collections.Generic;

    using Models;
    
    public interface IStudentService
    {
        IEnumerable<StudentServiceModel> GetStudents();
    }
}
