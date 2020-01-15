namespace StudentSystem.ViewModels.UserProfiles.Teacher
{
    using System.Linq;
    using System.Collections.Generic;
    using Prism.Commands;

    using Services;
    using Services.Models;
    using Services.Contracts;

    public class TeacherCoursesViewModel : BaseViewModel
    {
        #region Declarations

        private ITeacherCourseService courseService;

        private ITeacherStudentService studentService;

        private IEnumerable<TeacherCourseServiceModel> courses;

        private IList<TeacherStudentServiceModel> students;

        private string selectedCourseName;

        private int selectedCourseId;

        private string exceptionMessage;

        private DelegateCommand<object> selectCourseCommand;

        private DelegateCommand saveChangesCommand;

        private DelegateCommand resetChangesCommand;

        #endregion

        #region Initializations

        public TeacherCoursesViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public IEnumerable<TeacherCourseServiceModel> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
                NotifyPropertyChanged();
            }
        }

        public IList<TeacherStudentServiceModel> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
                NotifyPropertyChanged();
            }
        }

        public string SelectedCourseName
        {
            get
            {
                return this.selectedCourseName;
            }
            set
            {
                this.selectedCourseName = value;
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

        public DelegateCommand<object> SelectCourseCommand
        {
            get
            {
                if (this.selectCourseCommand == null)
                {
                    this.selectCourseCommand = new DelegateCommand<object>(SelectCourse);
                }

                return this.selectCourseCommand;
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
            this.courseService = new TeacherCourseService();
            this.studentService = new TeacherStudentService();

            this.Courses = courseService
                .GetTeacherCourses(User.UserId);

            var initializedCourse = this.Courses
                .FirstOrDefault();

            if (initializedCourse != null)
            {
                this.Students = studentService
                    .GetTeacherStudents(initializedCourse.CourseId);

                this.SelectedCourseName = courseService
                    .GetCourseName(initializedCourse.CourseId);

                this.selectedCourseId = initializedCourse.CourseId;
            }
        }

        private void SelectCourse(object courseId)
        {
            if (courseId == null)
            {
                return;
            }

            this.selectedCourseId = (int)courseId;

            this.Students = studentService
                .GetTeacherStudents(selectedCourseId);

            this.SelectedCourseName = courseService
                .GetCourseName(selectedCourseId);

            this.ExceptionMessage = string.Empty;
        }

        private void SaveChanges()
        {
            try
            {
                this.studentService.SaveStudentMarks(Students, selectedCourseId);

                this.Students = studentService
                    .GetTeacherStudents(selectedCourseId);

                this.ExceptionMessage = string.Empty;
            }
            catch (System.InvalidOperationException ioex)
            {
                this.ExceptionMessage = ioex.Message;
            }
        }

        private void ResetChanges()
        {
            this.Students = studentService
                .GetTeacherStudents(selectedCourseId);

            this.ExceptionMessage = string.Empty;
        }

        #endregion
    }
}
