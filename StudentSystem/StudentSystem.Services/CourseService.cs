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
        #endregion

        #region Initializations
        #endregion

        #region Properties
        #endregion

        #region Methods

        public IEnumerable<TeacherCourse> GetTeacherCourses(int userId)
        {
            IEnumerable<TeacherCourse> course = new List<TeacherCourse>();

            using (var context = new StudentSystemDbContext())
            {
                course = context.Courses
                    .Where(x => x.Teacher.UserId == userId)
                    .Select(x => new TeacherCourse()
                    {
                        CourseId = x.CourseId,
                        Name = x.Name,
                        StartDate = x.StartDate.ToString("MM/dd/yyyy"),
                        EndDate = x.EndDate.ToString("MM/dd/yyyy"),
                        ExamDate = x.ExamDate.ToString("MM/dd/yyyy"),
                        StudentsEnrolled = x.StudentsEnrolled.Count,
                    })
                    .ToList();
            }

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
