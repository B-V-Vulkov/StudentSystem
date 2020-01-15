namespace StudentSystem.ViewModels
{
    using System.Collections.Generic;

    using Services;
    using Services.Models;
    using Services.Contracts;

    public class CoursesViewModel
    {
        #region Declarations

        private ICourseService courseService;

        #endregion

        #region Initializations

        public CoursesViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public IEnumerable<CourseServiceModel> Courses { get; set; }

        #endregion

        #region Methods

        private void Initialize()
        {
            this.courseService = new CourseService();

            this.Courses = courseService.GetCourses();
        }

        #endregion
    }
}
