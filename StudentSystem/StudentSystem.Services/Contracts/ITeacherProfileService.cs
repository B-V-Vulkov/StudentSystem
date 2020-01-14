namespace StudentSystem.Services.Contracts
{
    using Models;

    public interface ITeacherProfileService
    {
        TeacherProfileServiceModel GetTeacherProfile(int userId);
    }
}
