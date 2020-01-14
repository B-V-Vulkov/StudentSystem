namespace StudentSystem.Services.Contracts
{
    using Models;

    public interface IStudentProfileService
    {
        StudentProfileServiceModel GetStudentProfile(int userId);
    }
}
