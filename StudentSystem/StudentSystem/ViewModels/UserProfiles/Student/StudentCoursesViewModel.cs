namespace StudentSystem.ViewModels.UserProfiles.Student
{
    using System.Collections.Generic;

    using Services;
    using Services.Models;
    using Services.Contracts;

    public class StudentCoursesViewModel : BaseViewModel
    {
        #region Declarations

        private IStudentCourseService studentCourseService;

        #endregion

        #region Initializations

        public StudentCoursesViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public IEnumerable<StudentCourseServiceModel> Courses { get; set; }

        #endregion

        #region Methods

        private void Initialize() 
        {
            this.studentCourseService = new StudentCourseService();

            this.Courses = studentCourseService.GetStudentCourses(User.UserId);
        }

        #endregion
    }
}
