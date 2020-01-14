namespace StudentSystem.ViewModels.UserProfiles.Student
{
    using Services;
    using StudentSystem.Services.Models;
    using System.Collections.Generic;

    public class StudentCoursesViewModel : BaseViewModel
    {
        #region Declarations

        private CourseService courseService;

        private List<StudentCourseServiceModel> courses;

        #endregion

        #region Initializations

        public StudentCoursesViewModel()
        {
            this.courseService = new CourseService();
            this.Courses = courseService.GetStudentCourses(7);
        }

        #endregion

        #region Properties

        public List<StudentCourseServiceModel> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }

        #endregion

        #region Methods
        #endregion
    }
}
