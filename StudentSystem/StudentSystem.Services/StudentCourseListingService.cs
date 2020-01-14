namespace StudentSystem.Services
{
    using System.Linq;
    using System.Collections.Generic;

    using Data;
    using Models;
    using Contracts;

    public class StudentCourseListingService : BaseService, IStudentCourseListingService
    {
        #region Declarations
        #endregion

        #region Initializations

        public StudentCourseListingService(StudentSystemDbContext dbContext) 
            : base(dbContext)
        {

        }

        #endregion

        #region Properties
        #endregion

        #region Methods

        //public IEnumerable<StudentCourseListingServiceModel> GetStudentCourses(int userId)
        //{
        //    var courses = data.Students
        //       .Where(x => x.Student.UserId == userId)
        //        .Select(x => new StudentCourseServiceModel()
        //        {
        //            Name = x.Course.Name,
        //            StartDate = x.Course.StartDate.ToString(STRING_DATE_FORMAT),
        //            EndDate = x.Course.EndDate.ToString(STRING_DATE_FORMAT),
        //            ExamDate = x.Course.ExamDate.ToString(STRING_DATE_FORMAT),
        //            Mark = x.Mark,
        //        })
        //        .ToList();

        //    return courses;
        //}

        #endregion
    }
}
