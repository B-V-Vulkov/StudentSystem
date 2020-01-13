namespace StudentSystem.Services
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Data;
    using Models;
    using static Common.ExceptionMessage;
    using static Common.GlobalConstants;

    public class CourseService
    {
        #region Declarations

        private StudentSystemDbContext context;

        #endregion

        #region Initializations

        public CourseService()
        {
            this.context = new StudentSystemDbContext();
        }

        #endregion

        #region Properties
        #endregion

        #region Methods

        public List<TeacherCourse> GetTeacherCourses(int userId)
        {
            List<TeacherCourse> course = new List<TeacherCourse>();

            course = context.Courses
                .Where(x => x.Teacher.UserId == userId)
                .Select(x => new TeacherCourse()
                {
                    CourseId = x.CourseId,
                    Name = x.Name,
                    StartDate = x.StartDate.ToString(STRING_DATE_FORMAT),
                    EndDate = x.EndDate.ToString(STRING_DATE_FORMAT),
                    ExamDate = x.ExamDate.ToString(STRING_DATE_FORMAT),
                    StudentsEnrolled = x.StudentsEnrolled.Count,
                })
                .ToList();

            return course;
        }

        public List<StudentCourse> GetStudentCourses(int userId)
        {
            List<StudentCourse> course;

            course = context.StudentCourses
                .Where(x => x.Student.UserId == userId)
                .Select(x => new StudentCourse()
                {
                    Name = x.Course.Name,
                    StartDate = x.Course.StartDate.ToString(STRING_DATE_FORMAT),
                    EndDate = x.Course.EndDate.ToString(STRING_DATE_FORMAT),
                    ExamDate = x.Course.ExamDate.ToString(STRING_DATE_FORMAT),
                    Mark = x.Mark,
                })
                .ToList();

            return course;
        }

        public string GetCourseNameById(int courseId)
        {
            string courseName = string.Empty;

            using (var context = new StudentSystemDbContext())
            {
                courseName = context.Courses
                    .FirstOrDefault(x => x.CourseId == courseId).Name;
            }

            return courseName;
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

        private bool ValidateStudentsMark(IEnumerable<TeacherCourse> courses)
        {
            bool isValid = true;

            foreach (var course in courses)
            {
                //if (course.Mark > MAX_STUDENT_MARK || course.Mark < MIN_STUDENT_MARK)
                //{
                //    isValid = false;
                //    break;
                //}
            }

            return isValid;
        }

        #endregion
    }
}
