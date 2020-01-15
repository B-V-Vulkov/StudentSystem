namespace StudentSystem.Services.Contracts
{
    using StudentSystem.Services.Models;

    public interface IAdministratorCoursesService
    {
        void SaveCourse(AdministratorCourseServiceModel inputCourseInfo);
    }
}
