namespace StudentSystem.ViewModels.UserProfiles.Administrator
{
    using System;
    using System.Globalization;
    using Prism.Commands;

    using Services;
    using Services.Models;
    using Services.Contracts;

    using static Common.IconsSource;
    using static Common.DataValidations;
    using static Common.GlobalConstants;
    using static Common.ConfirmationMessages;

    public class AdministratorCoursesViewModel : BaseViewModel
    {
        #region Declarations

        private IAdministratorCoursesService administratorCoursesService;

        private string courseName;

        private string startDate;

        private string endDate;

        private string examDate;

        private string courseNameValidationIconSource;

        private string startDateValidationIconSource;

        private string endDateValidationIconSource;

        private string examDateValidationIconSource;

        private string exceptionMessage;

        private string confirmationMessages;

        private DelegateCommand saveChangesCommand;

        private DelegateCommand resetChangesCommand;

        #endregion

        #region Initializations

        public AdministratorCoursesViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public string CourseName
        {
            get
            {
                return this.courseName;
            }
            set
            {
                this.courseName = value;
                ValidateCourseName(value);
                NotifyPropertyChanged();
            }
        }

        public string StartDate
        {
            get
            {
                return this.startDate;
            }
            set
            {
                this.startDate = value;
                ValidateStartDate(value);
                NotifyPropertyChanged();
            }
        }

        public string EndDate
        {
            get
            {
                return this.endDate;
            }
            set
            {
                this.endDate = value;
                ValidateEndDate(value);
                NotifyPropertyChanged();
            }
        }

        public string ExamDate
        {
            get
            {
                return this.examDate;
            }
            set
            {
                this.examDate = value;
                ValidateExamDate(value);
                NotifyPropertyChanged();
            }
        }

        public string CourseNameValidationIconSource
        {
            get
            {
                return this.courseNameValidationIconSource;
            }
            set
            {
                this.courseNameValidationIconSource = value;
                NotifyPropertyChanged();
            }
        }

        public string StartDateValidationIconSource
        {
            get
            {
                return this.startDateValidationIconSource;
            }
            set
            {
                this.startDateValidationIconSource = value;
                NotifyPropertyChanged();
            }
        }

        public string EndDateValidationIconSource
        {
            get
            {
                return this.endDateValidationIconSource;
            }
            set
            {
                this.endDateValidationIconSource = value;
                NotifyPropertyChanged();
            }
        }

        public string ExamDateValidationIconSource
        {
            get
            {
                return this.examDateValidationIconSource;
            }
            set
            {
                this.examDateValidationIconSource = value;
                NotifyPropertyChanged();
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

        private void Initialize()
        {
            this.administratorCoursesService = new AdministratorCoursesService();
        }

        private void SaveChanges()
        {
            var course = new AdministratorCourseServiceModel()
            {
                Name = this.CourseName,
                StartDate = this.StartDate,
                EndDate = this.EndDate,
                ExamDate = this.ExamDate,
            };

            try
            {
                administratorCoursesService.SaveCourse(course);

                this.ConfirmationMessages = string.Format(SUCCESSFULLY_ADDED_COURSE, this.CourseName);
                ResetViewFields();
            }
            catch (InvalidOperationException ioex)
            {
                this.ExceptionMessage = ioex.Message;
                this.ConfirmationMessages = String.Empty;
            }
        }

        private void ResetChanges()
        {
            ResetViewFields();
            this.ConfirmationMessages = String.Empty;
        }

        private void ResetViewFields()
        {
            this.CourseName = String.Empty;
            this.StartDate = String.Empty;
            this.EndDate = String.Empty;
            this.ExamDate = String.Empty;

            this.CourseNameValidationIconSource = String.Empty;
            this.StartDateValidationIconSource = String.Empty;
            this.EndDateValidationIconSource = String.Empty;
            this.ExamDateValidationIconSource = String.Empty;

            this.ExceptionMessage = String.Empty;
        }

        private void ValidateCourseName(string input)
        {
            if (input.Length < COURSE_NAME_MIN_LENGTH || input.Length > COURSE_NAME_MAX_LENGTH)
            {
                this.CourseNameValidationIconSource = INVALID_INPUT;
            }
            else
            {
                this.CourseNameValidationIconSource = VALID_INPUT;
            }
        }

        private void ValidateStartDate(string date)
        {
            if (!ValidateDate(date))
            {
                this.StartDateValidationIconSource = INVALID_INPUT;
            }
            else
            {
                this.StartDateValidationIconSource = VALID_INPUT;
            }
        }

        private void ValidateEndDate(string date)
        {
            if (!ValidateDate(date))
            {
                this.EndDateValidationIconSource = INVALID_INPUT;
            }
            else
            {
                this.EndDateValidationIconSource = VALID_INPUT;
            }
        }

        private void ValidateExamDate(string date)
        {
            if (!ValidateDate(date))
            {
                this.ExamDateValidationIconSource = INVALID_INPUT;
            }
            else
            {
                this.ExamDateValidationIconSource = VALID_INPUT;
            }
        }

        private bool ValidateDate(string date)
        {
            bool isValid = DateTime.TryParseExact(date,
                STRING_DATE_FORMAT,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out _);

            return isValid;
        }

        #endregion
    }
}
