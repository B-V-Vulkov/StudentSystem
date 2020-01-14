namespace StudentSystem.Services
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Data;
    using Models;
    using Contracts;

    public class StudentService : IStudentService
    {
        public IEnumerable<StudentServiceModel> GetStudents()
        {
            IEnumerable<StudentServiceModel> students;

            using (var data = new StudentSystemDbContext())
            {
                students = data.Students
                    .Select(x => new StudentServiceModel()
                    {
                        FirstName = x.User.FirstName,
                        MiddleName = x.User.MiddleName,
                        LastName = x.User.LastName,
                        StudentId = x.StudentId,
                        Department = x.User.Department.Name,
                        AverageMark = x.CoursesEnrolled.Average(m => m.Mark),
                        Town = x.User.Town.Name
                    })
                    .OrderByDescending(X => X.AverageMark)
                    .ToList();
            }

            foreach (var student in students)
            {
                if (student.AverageMark != null)
                {
                    student.AverageMark = Math.Round((double)student.AverageMark, 2);
                }
            }

            return students;
        }
    }
}
