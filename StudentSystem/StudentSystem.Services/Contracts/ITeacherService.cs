namespace StudentSystem.Services.Contracts
{
    using System.Collections.Generic;
 
    using Models;

    public interface ITeacherService
    {
        IEnumerable<TeacherServiceModel> GetTeachers();
    }
}
