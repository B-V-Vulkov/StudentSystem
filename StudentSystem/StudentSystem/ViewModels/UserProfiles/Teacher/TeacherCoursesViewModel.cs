namespace StudentSystem.ViewModels.UserProfiles.Teacher
{
    using System;
    using System.Collections.Generic;
    using Prism.Commands;

    using Services;
    using Services.Models;
    using StudentSystem.Common;

    public class TeacherCoursesViewModel
    {
        #region Declarations

        private CourseService courseService;

        private StudentService studentService;

        private IEnumerable<TeacherStudent> students;

        private IEnumerable<TeacherCourse> courses;

        private DelegateCommand<string> selectCourseCommand;

        #endregion

        #region Initializations

        public TeacherCoursesViewModel()
        {
            this.courseService = new CourseService();
            this.studentService = new StudentService();

            this.courses = new List<TeacherCourse>();
            this.students = new List<TeacherStudent>();

            this.Courses = courseService.GetTeacherCourses(User.UserId);
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
            }
        }

        public DelegateCommand<string> SelectCourseCommand
        {
            get
            {
                if (this.selectCourseCommand == null)
                {
                    this.selectCourseCommand = new DelegateCommand<string>(SelectCourse);
                }

                return this.selectCourseCommand;
            }
        }

        #endregion

        #region Methods

        private void SelectCourse(string courseId)
        {
            this.Students = studentService.GetTeacherStudents(int.Parse(courseId));
        }

        #endregion
    }
}
