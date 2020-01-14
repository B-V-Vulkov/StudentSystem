namespace StudentSystem.ViewModels
{
    using System.Collections.Generic;

    using Data;
    using Services;
    using Services.Models;

    public class StudentsViewModel : BaseViewModel
    {
        #region Declarations

        private StudentListingService studentService;

        #endregion

        #region Initializations

        public StudentsViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public IEnumerable<StudentCourseListingServiceModel> Students { get; set; }

        #endregion

        #region Methods

        private void Initialize()
        {
            using var dbContext = new StudentSystemDbContext();

            this.studentService = new StudentListingService(dbContext);

            this.Students = studentService.GetStudents();
        }

        #endregion
    }
}
