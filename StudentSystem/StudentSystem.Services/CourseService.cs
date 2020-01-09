namespace StudentSystem.Services
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Models;
    using StudentSystem.Data;
    using static Common.ExceptionMessage;
    using static Common.GlobalConstants;

    public class CourseService
    {
        #region Declarations
        #endregion

        #region Initializations
        #endregion

        #region Properties
        #endregion

        #region Methods

        public List<Course> GetCourses()
        {
            var data = new StudentSystemContext();

            var courses = data.Courses
                .Select(x => new Course()
                {
                    Name = x.Name,
                })
                .ToList();

            return courses;
        }


        public void Save(IEnumerable<TeacherCourse> courses)
        {
            bool isValid = ValidateStudentsMark(courses);

            if (!isValid)
            {
                throw new InvalidOperationException(INVALID_STUDENT_MARK);
            }

            //TODO: Save changes to DB
        }

        public List<TeacherCourse> GetTeacherCourses(int teacherId)
        {
            List<TeacherCourse> courses = new List<TeacherCourse>();

            //TODO: Get courses for DB

            return courses;
        }

        private bool ValidateStudentsMark(IEnumerable<TeacherCourse> courses)
        {
            bool isValid = true;

            foreach (var course in courses)
            {
                if (course.Mark > MAX_STUDENT_MARK || course.Mark < MIN_STUDENT_MARK)
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        #endregion
    }
}
