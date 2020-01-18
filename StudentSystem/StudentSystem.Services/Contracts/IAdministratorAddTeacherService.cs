namespace StudentSystem.Services.Contracts
{
    using System.Collections.Generic;

    using Models;

    public interface IAdministratorAddTeacherService
    {
        void AddTeacher(AdministratorAddTeacherServiceModel teacher);

        IList<string> GetDepartments();
    }
}
