namespace StudentSystem.Services
{
    using System.Linq;

    using Data;
    using Models;
    using Contracts;

    public class TeacherProfileService : ITeacherProfileService
    {
        public TeacherProfileServiceModel GetTeacherProfile(int userId)
        {
            TeacherProfileServiceModel teacher;

            using (var data = new StudentSystemDbContext())
            {
                teacher = data.Teachers
                    .Where(x => x.UserId == userId)
                    .Select(x => new TeacherProfileServiceModel()
                    {
                        FirstName = x.User.FirstName,
                        MiddleName = x.User.MiddleName,
                        LastName = x.User.LastName,
                        Department = x.User.Department.Name,
                        Courses = x.Courses.Count,
                        Students = x.Courses.Select(s => s.StudentsEnrolled.Count)
                                            .ToArray().Sum(),
                    })
                    .FirstOrDefault();
            }

            return teacher;
        }
    }
}
