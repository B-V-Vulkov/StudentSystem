namespace StudentSystem.Services
{
    using System.Linq;
    using System.Collections.Generic;

    using Data;
    using Models;
    using Contracts;

    public class TeacherService : ITeacherService
    {
        public IEnumerable<TeacherServiceModel> GetTeachers()
        {
            IEnumerable<TeacherServiceModel> teachers;

            using (var data = new StudentSystemDbContext())
            {
                teachers = data.Teachers
                    .Select(x => new TeacherServiceModel()
                    {
                        FirstName = x.User.FirstName,
                        MiddleName = x.User.MiddleName,
                        LastName = x.User.LastName,
                        Department = x.User.Department.Name,
                        Courses = x.Courses.Count,
                        Students = x.Courses.Select(s => s.StudentsEnrolled.Count).ToArray().Sum(),
                        Town = x.User.Town.Name
                    })
                    .OrderByDescending(X => X.Courses)
                    .ToList();
            }

            return teachers;
        }
    }
}
