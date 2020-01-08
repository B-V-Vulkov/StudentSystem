namespace StudentSystem.ViewModels
{
    using System.Collections.Generic;

    using Services.Models;
    using Services.Services;

    public class StudentsViewModel
    {
        #region Declarations

        private List<Student> students;

        private StudentService service;

        #endregion

        #region Initializations

        public StudentsViewModel()
        {
            this.service = new StudentService();
            this.Students = service.GetAllStudents();
        }

        #endregion

        #region Properties

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        #endregion

        #region Methods
        #endregion
    }
}
