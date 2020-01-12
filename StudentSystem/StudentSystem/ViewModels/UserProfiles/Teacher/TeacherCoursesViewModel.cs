namespace StudentSystem.ViewModels.UserProfiles.Teacher
{
    using System.Linq;
    using System.Collections.Generic;
    using Prism.Commands;

    using Common;
    using Services;
    using Services.Models;

    public class TeacherCoursesViewModel : BaseViewModel
    {
        #region Declarations

        private CourseService courseService;

        private StudentService studentService;

        private List<TeacherStudent> students;

        private List<TeacherCourse> courses;

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

        public List<TeacherStudent> Students
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
            this.courseService = new CourseService();
            this.studentService = new StudentService();

            this.courses = new List<TeacherCourse>();
            this.students = new List<TeacherStudent>();

            this.Courses = courseService
                .GetTeacherCourses(User.UserId);

            var initializedCourse = this.Courses
                .FirstOrDefault();

            if (initializedCourse != null)
            {
                this.Students = studentService
                    .GetTeacherStudents(initializedCourse.CourseId);

                this.SelectedCourseName = courseService
                    .GetCourseNameById(initializedCourse.CourseId);

                this.selectedCourseId = initializedCourse.CourseId;
            }
        }

        private void SelectCourse(object courseId)
        {
            if (courseId == null)
            {
                return;
            }

            this.Students = studentService
                .GetTeacherStudents((int)courseId);

            this.SelectedCourseName = courseService
                .GetCourseNameById((int)courseId);

            this.selectedCourseId = (int)courseId;

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
