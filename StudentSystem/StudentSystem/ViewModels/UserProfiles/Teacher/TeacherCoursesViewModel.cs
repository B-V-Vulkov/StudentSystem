namespace StudentSystem.ViewModels.UserProfiles.Teacher
{
    using System;
    using System.Collections.Generic;
    using Prism.Commands;

    using Services;
    using Services.Models;

    public class TeacherCoursesViewModel
    {
        #region Declarations

        private string exceptionMessage;

        private CourseService coursService;

        private List<TeacherCourse> courses;

        private DelegateCommand saveChangesCommand;

        private DelegateCommand resetChangesCommand;

        #endregion

        #region Initializations

        public TeacherCoursesViewModel()
        {
            this.coursService = new CourseService();
            this.courses = new List<TeacherCourse>();
        }

        #endregion

        #region Properties

        public string ExceptionMessage
        {
            get
            {
                return this.exceptionMessage;
            }
            private set
            {
                this.exceptionMessage = value;
            }
        }

        public List<TeacherCourse> Courses
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

        public DelegateCommand SaveChangesCommand
        {
            get
            {
                if (this.saveChangesCommand == null)
                {
                    this.saveChangesCommand = new DelegateCommand(SaveChanges);
                }

                return this.saveChangesCommand;
            }
        }

        public DelegateCommand ResetChangesCommand
        {
            get
            {
                if (this.resetChangesCommand == null)
                {
                    this.resetChangesCommand = new DelegateCommand(ResetChanges);
                }

                return this.resetChangesCommand;
            }
        }

        #endregion

        #region Methods

        private void SaveChanges()
        {
            try
            {
                coursService.Save(this.Courses);
            }
            catch (InvalidOperationException ioex)
            {
                this.ExceptionMessage = ioex.Message;
            }
        }

        private void ResetChanges()
        {
            this.Courses = coursService.GetTeacherCourses(12);
        }

        #endregion
    }
}
