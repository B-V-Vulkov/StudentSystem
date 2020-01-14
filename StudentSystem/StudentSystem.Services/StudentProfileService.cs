namespace StudentSystem.Services
{
    using System.Linq;

    using Data;
    using Models;
    using Contracts;

    public class StudentProfileService : IStudentProfileService
    {
        public StudentProfileServiceModel GetStudentProfile(int userId)
        {
            StudentProfileServiceModel student;

            using (var data = new StudentSystemDbContext())
            {
                student = data.Students
                    .Where(x => x.UserId == userId)
                    .Select(x => new StudentProfileServiceModel()
                    {
                        FirstName = x.User.FirstName,
                        MiddleName = x.User.MiddleName,
                        LastName = x.User.LastName,
                        Department = x.User.Department.Name,
                        StudentId = x.StudentId,
                        Courses = x.CoursesEnrolled.Count,
                        AverageMark = x.CoursesEnrolled.Average(m => m.Mark),
                    })
                    .FirstOrDefault();
            }

            return student;
        }
    }
}
