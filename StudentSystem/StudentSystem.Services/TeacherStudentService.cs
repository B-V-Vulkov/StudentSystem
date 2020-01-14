namespace StudentSystem.Services
{
    using System.Linq;
    using System.Collections.Generic;

    using Data;
    using Models;
    using Contracts;
    using System;

    public class TeacherStudentService : ITeacherStudentService
    {
        public IList<TeacherStudentServiceModel> GetTeacherStudents(int courseId)
        {
            IList<TeacherStudentServiceModel> students;

            using (var data = new StudentSystemDbContext())
            {
                var exportData = data.StudentCourses
                    .Where(x => x.CourseId == courseId)
                    .Select(x => new TeacherStudentServiceModel()
                    {
                        FirstName = x.Student.User.LastName,
                        MiddleName = x.Student.User.MiddleName,
                        LastName = x.Student.User.LastName,
                        StudentId = x.StudentId,
                        Mark = x.Mark,
                    })
                    .ToList();

                students = exportData;
            }

            return students;
        }

        public void SaveStudentMarks(IList<TeacherStudentServiceModel> students, int courseId)
        {
            using (var data = new StudentSystemDbContext())
            {
                var exportData = data.StudentCourses
                    .Where(x => x.CourseId == courseId)
                    .ToArray();

                for (int i = 0; i < exportData.Length; i++)
                {
                    var mark = students[i].Mark;

                    if (mark != null)
                    {
                        exportData[i].Mark = Math.Round((double)mark, 2, MidpointRounding.ToEven);
                    }
                }

                data.SaveChanges();
            }
        }
    }
}
