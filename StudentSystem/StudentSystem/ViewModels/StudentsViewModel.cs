﻿namespace StudentSystem.ViewModels
{
    using System.Collections.Generic;

    using Services;
    using Services.Models;
    using Services.Contracts;

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
            this.studentService = new StudentService();

            this.Students = studentService.GetStudents();
        }

        #endregion
    }
}
