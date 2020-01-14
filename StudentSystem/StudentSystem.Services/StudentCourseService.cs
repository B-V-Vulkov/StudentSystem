namespace StudentSystem.Services
{
    using System.Linq;
    using System.Collections.Generic;

    using Data;
    using Models;
    using Contracts;

    using static Common.GlobalConstants;

    public class StudentCourseService : IStudentCourseService
    {
        public IEnumerable<StudentCourseServiceModel> GetStudentCourses(int userId)
        {
            IEnumerable<StudentCourseServiceModel> courses;

            using (var data = new StudentSystemDbContext())
            {
                courses = data.StudentCourses
                    .Where(x => x.Student.UserId == userId)
                    .Select(x => new StudentCourseServiceModel()
                    {
                        Name = x.Course.Name,
                        StartDate = x.Course.StartDate.ToString(STRING_DATE_FORMAT),
                        EndDate = x.Course.EndDate.ToString(STRING_DATE_FORMAT),
                        ExamDate = x.Course.ExamDate.ToString(STRING_DATE_FORMAT),
                        Mark = x.Mark,
                    })
                    .ToList();
            }
            
            return courses;
        }
    }
}
