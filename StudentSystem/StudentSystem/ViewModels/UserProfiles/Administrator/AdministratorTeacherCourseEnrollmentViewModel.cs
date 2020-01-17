namespace StudentSystem.ViewModels.UserProfiles.Administrator
{
    using System;
    using System.Collections.Generic;
    using Prism.Commands;

    using Services;
    using Services.Contracts;

    using static Common.ConfirmationMessages;

    public class AdministratorTeacherCourseEnrollmentViewModel : BaseViewModel
    {
        #region Declarations

        private IAdministratorTeacherCourseEnrollmentService administratorTeacherCourseEnrollmentService;

        private string exceptionMessage;

        private string confirmationMessages;

        private DelegateCommand saveChangesCommand;

        #endregion

        #region Initializations

        public AdministratorTeacherCourseEnrollmentViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public IList<string> Teachers { get; set; }

        public IList<string> Courses { get; set; }

        public string SelectedTeacher { get; set; }

        public string SelectedCourse { get; set; }

        public string ExceptionMessage
        {
            get
            {
                return this.exceptionMessage;
            }
            set
            {
                this.exceptionMessage = value;
                NotifyPropertyChanged();
            }
        }

        public string ConfirmationMessages
        {
            get
            {
                return this.confirmationMessages;
            }
            set
            {
                this.confirmationMessages = value;
                NotifyPropertyChanged();
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

        #endregion

        #region Methods

        private void Initialize()
        {
            this.administratorTeacherCourseEnrollmentService = new AdministratorTeacherCourseEnrollmentService();

            this.Teachers = administratorTeacherCourseEnrollmentService.GetTeachers();
            this.Courses = administratorTeacherCourseEnrollmentService.GetCourses();
        }

        private void SaveChanges()
        {
            try
            {
                this.administratorTeacherCourseEnrollmentService.SaveCourseEnrollment(this.SelectedTeacher, this.SelectedCourse);

                this.ExceptionMessage = String.Empty;
                this.ConfirmationMessages = String.Empty;

                this.ConfirmationMessages = string.Format(SUCCESSFULLY_ENROLLED_TEACHER, this.SelectedTeacher, this.SelectedCourse);
            }
            catch (InvalidOperationException ioex)
            {
                this.ExceptionMessage = ioex.Message;
                this.ConfirmationMessages = String.Empty;
            }
        }

        #endregion
    }
}
