namespace StudentSystem.ViewModels.UserProfiles.Teacher
{
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
            this.profileService = new TeacherProfileService();

            this.Teacher = profileService.GetTeacherProfile(User.UserId);
        }

        #endregion
    }
}
