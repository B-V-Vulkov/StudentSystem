namespace StudentSystem.Services
{
    using System.Linq;
    using System.Collections.Generic;

    using Data;
    using Models;
    using Contracts;

    using static Common.GlobalConstants;

    public class CourseService : ICourseService
    {
        public IEnumerable<CourseServiceModel> GetCourses()
        {
            IEnumerable<CourseServiceModel> courses;

            using (var data = new StudentSystemDbContext())
            {
                courses = data.Courses
                    .Select(x => new CourseServiceModel()
                    {
                        Name = x.Name,
                        StartDate = x.StartDate.ToString(STRING_DATE_FORMAT),
                        EndDate = x.EndDate.ToString(STRING_DATE_FORMAT),
                        ExamDate = x.ExamDate.ToString(STRING_DATE_FORMAT),
                        Teacher = string.Concat(x.Teacher.User.FirstName, " ", x.Teacher.User.LastName),
                        Students = x.StudentsEnrolled.Count,
                    })
                    .OrderByDescending(x => x.Students)
                    .ToList();
            }

            return courses;
        }
    }
}
