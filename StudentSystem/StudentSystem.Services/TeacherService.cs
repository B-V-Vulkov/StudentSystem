namespace StudentSystem.Services
{
    using System.Linq;

    using Data;
    using Models;

    public class TeacherService
    {
        public TeacherProfile GetTeacherProfileInfo(int userId)
        {
            TeacherProfile teacher;

            using (var context = new StudentSystemDbContext())
            {
                teacher = context.Teachers
                    .Where(x => x.UserId == userId)
                    .Select(x => new TeacherProfile
                    {
                        FirstName = x.User.FirstName,
                        MiddleName = x.User.MiddleName,
                        LastName = x.User.LastName,
                        Department = x.User.Department.Name,
                        Courses = x.Courses.Count,
                        Students = x.Courses.Select(s => s.StudentsEnrolled.Count).ToArray().Sum()
                    })
                    .FirstOrDefault();
            }

            return teacher;
        }
    }
}
