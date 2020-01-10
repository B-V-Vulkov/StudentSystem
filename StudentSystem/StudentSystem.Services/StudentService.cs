namespace StudentSystem.Services
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Data;
    using Models;
    using static Common.ExceptionMessage;
    using static Common.GlobalConstants;

    public class StudentService
    {
        #region Declarations
        #endregion

        #region Initializations
        #endregion

        #region Properties
        #endregion

        #region Methods

        public IEnumerable<TeacherStudent> GetTeacherStudents(int courseId)
        {
            IEnumerable<TeacherStudent> students = new List<TeacherStudent>();

            using (var context = new StudentSystemDbContext())
            {
                students = context.StudentCourses
                    .Where(x => x.CourseId == courseId)
                    .Select(x => new TeacherStudent()
                    {
                        FirstName = x.Student.User.LastName,
                        MiddleName = x.Student.User.MiddleName,
                        LastName = x.Student.User.LastName,
                        StudentId = x.StudentId,
                        Mark = x.Mark,
                    })
                    .ToList();
            }

            return students;
        }
        #endregion
    }
}
