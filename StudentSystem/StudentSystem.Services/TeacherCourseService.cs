namespace StudentSystem.Services
{
    using System.Linq;
    using System.Collections.Generic;

    using Data;
    using Models;
    using Contracts;

    using static Common.GlobalConstants;

    public class TeacherCourseService : ITeacherCourseService
    {
        public IEnumerable<TeacherCourseServiceModel> GetTeacherCourses(int userId)
        {
            IEnumerable<TeacherCourseServiceModel> courses;

            using (var data = new StudentSystemDbContext())
            {
                courses = data.Courses
                    .Where(x => x.Teacher.UserId == userId)
                    .Select(x => new TeacherCourseServiceModel()
                    {
                        CourseId = x.CourseId,
                        Name = x.Name,
                        StartDate = x.StartDate.ToString(STRING_DATE_FORMAT),
                        EndDate = x.EndDate.ToString(STRING_DATE_FORMAT),
                        ExamDate = x.ExamDate.ToString(STRING_DATE_FORMAT),
                        StudentsEnrolled = x.StudentsEnrolled.Count,
                    })
                    .OrderBy(x => x.CourseId)
                    .ToList();
            }

            return courses;
        }

        public string GetCourseName(int courseId)
        {
            string courseName;

            using (var data = new StudentSystemDbContext())
            {
                courseName = data.Courses
                    .FirstOrDefault(x => x.CourseId == courseId)
                    .Name;
            }

            return courseName;
        }
    }
}
