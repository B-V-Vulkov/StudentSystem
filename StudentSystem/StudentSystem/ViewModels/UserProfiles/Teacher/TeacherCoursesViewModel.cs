namespace StudentSystem.ViewModels.UserProfiles.Teacher
{
    using System;
    using System.Collections.Generic;
    using Prism.Commands;

    using Services;
    using Services.Models;
    using StudentSystem.Common;
    using System.Linq;

    public class TeacherCoursesViewModel : BaseViewModel
    {
        #region Declarations

        private CourseService courseService;

        private StudentService studentService;

        private IEnumerable<TeacherStudent> students;

        private IEnumerable<TeacherCourse> courses;

        private string nameOfCurrentCourse;

        private DelegateCommand<object> selectCourseCommand;

        #endregion

        #region Initializations

        public TeacherCoursesViewModel()
        {
            Initialize();
        }

        #endregion

        #region Properties

        public IEnumerable<TeacherCourse> Courses
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

        public IEnumerable<TeacherStudent> Students
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

        public string NameOfCurrentCourse
        {
            get
            {
                return this.nameOfCurrentCourse;
            }
            set
            {
                this.nameOfCurrentCourse = value;
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

        #endregion

        #region Methods

        private void SelectCourse(object courseId)
        {
            this.NameOfCurrentCourse = courseService.GetCourseNameById((int)courseId);
            this.Students = studentService.GetTeacherStudents((int)courseId);
        }

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
                this.NameOfCurrentCourse = courseService.GetCourseNameById(initializedCourse.CourseId);
                this.Students = studentService.GetTeacherStudents(initializedCourse.CourseId);
            }
        }

        #endregion
    }
}
