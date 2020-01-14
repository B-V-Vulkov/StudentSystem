namespace StudentSystem.ViewModels
{
    using System.Collections.Generic;

    using Data;
    using Services;
    using Services.Contracts;
    using StudentSystem.Services.Models;

    public class StudentsViewModel : BaseViewModel
    {
        #region Declarations

        private IStudentService studentService;

        #endregion

        #region Initializations

        public StudentsViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public IEnumerable<StudentServiceModel> Students { get; set; }

        #endregion

        #region Methods

        private void Initialize()
        {
            using var dbContext = new StudentSystemDbContext();

            this.studentService = new StudentService(dbContext);

            this.Students = studentService.GetStudents();
        }

        #endregion
    }
}
