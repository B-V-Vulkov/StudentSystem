namespace StudentSystem.ViewModels.UserProfiles.Teacher
{
    using Common;
    using Data;
    using Services;
    using Services.Models;
    using Services.Contracts;

    public class TeacherProfileViewModel
    {
        #region Declarations

        private ITeacherProfileService profileService;

        #endregion

        #region Initializations

        public TeacherProfileViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public TeacherProfileServiceModel Teacher { get; set; }

        #endregion

        #region Methods

        private void Initialize()
        {
            using var dbContext = new StudentSystemDbContext();

            this.profileService = new TeacherProfileService(dbContext);

            this.Teacher = profileService.GetTeacherProfile(User.UserId);
        }

        #endregion
    }
}
