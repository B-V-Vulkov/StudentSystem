namespace StudentSystem.ViewModels.UserProfiles.Administrator
{
    using System;
    using Prism.Commands;

    using Services;
    using Services.Models;
    using Services.Contracts;

    public class AdministratorCoursesViewModel : BaseViewModel
    {
        #region Declarations

        private IAdministratorCoursesService administratorCoursesService;

        private DelegateCommand saveChangesCommand;

        private DelegateCommand resetChangesCommand;

        private string exceptionMessage;

        #endregion

        #region Initializations

        public AdministratorCoursesViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public AdministratorCourseServiceModel Course { get; set; }

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

        #endregion

        #region Methods

        private void Initialize()
        {
            this.administratorCoursesService = new AdministratorCoursesService();

            this.Course = new AdministratorCourseServiceModel();
        }

        private void SaveChanges()
        {
            try
            {
                administratorCoursesService.SaveCourse(this.Course);
            }
            catch (InvalidOperationException ioex)
            {
                this.ExceptionMessage = ioex.Message;
            }
        }

        private void ResetChanges()
        {
            
        }

        #endregion
    }
}
