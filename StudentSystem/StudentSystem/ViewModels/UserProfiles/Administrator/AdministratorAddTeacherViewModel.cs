namespace StudentSystem.ViewModels.UserProfiles.Administrator
{
    using System;
    using System.Collections.Generic;
    using Prism.Commands;

    using Services;
    using Services.Models;
    using Services.Contracts;

    using static Common.IconsSource;
    using static Common.DataValidations;
    using static Common.ConfirmationMessages;

    public class AdministratorAddTeacherViewModel : BaseViewModel
    {
        #region Declarations

        private IAdministratorAddTeacherService administratorAddTeacherService;

        private string firstName;

        private string middleName;

        private string lastName;

        private string town;

        private string firstNameValidationIconSource;

        private string middleNameValidationIconSource;

        private string lastNameValidationIconSource;

        private string townValidationIconSource;

        private string exceptionMessage;

        private string confirmationMessages;

        private DelegateCommand saveChangesCommand;

        private DelegateCommand resetChangesCommand;

        #endregion

        #region Initializations

        public AdministratorAddTeacherViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public IList<string> Departments { get; set; }

        public string SelectedDepartment { get; set; }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
                ValidateFirstName(value);
                NotifyPropertyChanged();
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
                ValidateMiddleName(value);
                NotifyPropertyChanged();
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
                ValidateLastName(value);
                NotifyPropertyChanged();
            }
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                this.town = value;
                ValidateTownName(value);
                NotifyPropertyChanged();
            }
        }

        public string FirstNameValidationIconSource
        {
            get
            {
                return this.firstNameValidationIconSource;
            }
            set
            {
                this.firstNameValidationIconSource = value;
                NotifyPropertyChanged();
            }
        }

        public string MiddleNameValidationIconSource
        {
            get
            {
                return this.middleNameValidationIconSource;
            }
            set
            {
                this.middleNameValidationIconSource = value;
                NotifyPropertyChanged();
            }
        }

        public string LastNameValidationIconSource
        {
            get
            {
                return this.lastNameValidationIconSource;
            }
            set
            {
                this.lastNameValidationIconSource = value;
                NotifyPropertyChanged();
            }
        }

        public string TownValidationIconSource
        {
            get
            {
                return this.townValidationIconSource;
            }
            set
            {
                this.townValidationIconSource = value;
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
            this.administratorAddTeacherService = new AdministratorAddTeacherService();

            this.Departments = administratorAddTeacherService.GetDepartments();
        }

        private void SaveChanges()
        {
            var teacher = new AdministratorAddTeacherServiceModel()
            {
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                LastName = this.LastName,
                Town = this.Town,
                Department = this.SelectedDepartment,
            };

            try
            {
                this.administratorAddTeacherService.AddTeacher(teacher);

                this.ConfirmationMessages = string.Format(SUCCESSFULLY_ADDED_TEACHER, this.FirstName, this.MiddleName, this.LastName);

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
            this.FirstName = String.Empty;
            this.MiddleName = String.Empty;
            this.LastName = String.Empty;
            this.Town = String.Empty;

            this.FirstNameValidationIconSource = String.Empty;
            this.MiddleNameValidationIconSource = String.Empty;
            this.LastNameValidationIconSource = String.Empty;
            this.TownValidationIconSource = String.Empty;

            this.ExceptionMessage = String.Empty;
        }

        private void ValidateFirstName(string input)
        {
            if (input.Length < USER_FIRST_NAME_MIN_LENGTH || input.Length > USER_FIRST_NAME_MAX_LENGTH)
            {
                this.FirstNameValidationIconSource = INVALID_INPUT;
            }
            else
            {
                this.FirstNameValidationIconSource = VALID_INPUT;
            }
        }

        private void ValidateMiddleName(string input)
        {
            if (input.Length < USER_MIDDLE_NAME_MIN_LENGTH || input.Length > USER_MIDDLE_NAME_MAX_LENGTH)
            {
                this.MiddleNameValidationIconSource = INVALID_INPUT;
            }
            else
            {
                this.MiddleNameValidationIconSource = VALID_INPUT;
            }
        }

        private void ValidateLastName(string input)
        {
            if (input.Length < USER_LAST_NAME_MIN_LENGTH || input.Length > USER_LAST_NAME_MAX_LENGTH)
            {
                this.LastNameValidationIconSource = INVALID_INPUT;
            }
            else
            {
                this.LastNameValidationIconSource = VALID_INPUT;
            }
        }

        private void ValidateTownName(string input)
        {
            if (input.Length < TOWN_NAME_MIN_LENGTH || input.Length > TOWN_NAME_MAX_LENGTH)
            {
                this.TownValidationIconSource = INVALID_INPUT;
            }
            else
            {
                this.TownValidationIconSource = VALID_INPUT;
            }
        }

        #endregion
    }
}
