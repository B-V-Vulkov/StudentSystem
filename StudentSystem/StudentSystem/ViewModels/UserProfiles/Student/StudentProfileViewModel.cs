namespace StudentSystem.ViewModels.UserProfiles.Student
{
    using Common;
    using Data;
    using Services;
    using Services.Models;
    using Services.Contracts;

    public class StudentProfileViewModel
    {
        #region Declarations

        private IStudentProfileService profileService;

        #endregion

        #region Initializations

        public StudentProfileViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public StudentProfileServiceModel Student { get; set; }

        #endregion

        #region Methods

        private void Initialize()
        {
            using var dbContext = new StudentSystemDbContext();

            this.profileService = new StudentProfileService(dbContext);

            this.Student = profileService.GetStudentProfile(User.UserId);
        }

        #endregion
    }
}
