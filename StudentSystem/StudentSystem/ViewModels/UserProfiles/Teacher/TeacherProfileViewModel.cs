using StudentSystem.Common;
using StudentSystem.Services;

namespace StudentSystem.ViewModels.UserProfiles.Teacher
{
    public class TeacherProfileViewModel
    {
        #region Declarations

        private TeacherService teacherService;

        #endregion

        #region Initializations

        public TeacherProfileViewModel()
        {
            this.teacherService = new TeacherService();
            Initialize();
        }

        #endregion

        #region Properties

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public int Courses { get; set; }

        public int Students { get; set; }

        #endregion

        #region Methods

        private void Initialize()
        {
            var teacher = teacherService.GetTeacherProfileInfo(User.UserId);

            this.FirstName = teacher.FirstName;
            this.MiddleName = teacher.MiddleName;
            this.LastName = teacher.LastName;
            this.Department = teacher.Department;
            this.Courses = teacher.Courses;
            this.Students = teacher.Students;
        }

        #endregion
    }
}
