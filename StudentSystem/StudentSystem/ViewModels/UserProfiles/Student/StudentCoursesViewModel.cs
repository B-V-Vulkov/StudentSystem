namespace StudentSystem.ViewModels.UserProfiles.Student
{
    using System.Collections.Generic;

    using Common;
    using Data;
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
            using var dbContext = new StudentSystemDbContext();

            this.studentCourseService = new StudentCourseService(dbContext);

            this.Courses = studentCourseService.GetStudentCourses(User.UserId);
        }

        #endregion
    }
}
