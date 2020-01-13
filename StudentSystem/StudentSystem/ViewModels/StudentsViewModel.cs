namespace StudentSystem.ViewModels
{
    using System.Collections.Generic;

    using Services.Models;
    using StudentSystem.Services;

    public class StudentsViewModel
    {
        #region Declarations

        private StudentService studentService;

        private List<Student> students;

        #endregion

        #region Initializations

        public StudentsViewModel()
        {
            this.studentService = new StudentService();
            this.Students = studentService.GetAllStudents();
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
