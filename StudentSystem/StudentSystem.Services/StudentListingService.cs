namespace StudentSystem.Services
{
    using System.Linq;
    using System.Collections.Generic;

    using Data;
    using Models;
    using Contracts;

    public class StudentListingService : BaseService, IStudentListingService
    {

        #region Declarations
        #endregion

        #region Initializations

        public StudentListingService(StudentSystemDbContext dbContext) 
            : base(dbContext)
        {

        }

        #endregion

        #region Properties
        #endregion

        #region Methods

        public IEnumerable<StudentCourseListingServiceModel> GetStudents()
        {
            var students = data.Students
                .Select(x => new StudentCourseListingServiceModel()
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

            return students;
        }

        #endregion
    }
}
