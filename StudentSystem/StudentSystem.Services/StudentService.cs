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
        #region Methods

        public List<TeacherStudent> GetTeacherStudents(int courseId)
        {
            List<TeacherStudent> students = new List<TeacherStudent>();

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

        public void SaveStudentMarks(IList<TeacherStudent> students, int courseId)
        {
            bool isValid = ValidateStudentsMark(students);

            if (!isValid)
            {
                throw new InvalidOperationException(INVALID_STUDENT_MARK);
            }

            using (var context = new StudentSystemDbContext())
            {
                var studentsForUpdate = context.StudentCourses
                    .Where(x => x.CourseId == courseId)
                    .ToArray();

                for (int i = 0; i < studentsForUpdate.Length; i++)
                {
                    var mark = students[i].Mark;

                    if (mark != null)
                    {
                        studentsForUpdate[i].Mark = Math.Round((double)mark, 2, MidpointRounding.ToEven);
                    }
                }

                context.SaveChanges();
            }
        }

        private bool ValidateStudentsMark(IEnumerable<TeacherStudent> students)
        {
            bool isValid = true;

            foreach (var student in students)
            {
                if (student.Mark != null 
                    && (student.Mark > MAX_STUDENT_MARK 
                    || student.Mark < MIN_STUDENT_MARK))
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
