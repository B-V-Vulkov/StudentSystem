namespace StudentSystem.Services
{
    using System;
    using System.Linq;
    using System.Globalization;

    using Data;
    using Data.Models;
    using Models;
    using Contracts;

    using static Common.GlobalConstants;
    using static Common.ExceptionMessage;

    public class AdministratorCoursesService : IAdministratorCoursesService
    {
        public void SaveCourse(AdministratorCourseServiceModel inputCourseInfo)
        {
            ValidateCourseInfo(inputCourseInfo);

            using (var data = new StudentSystemDbContext())
            {
                Course course = new Course()
                {
                    Name = inputCourseInfo.Name,
                    StartDate = DateTime.ParseExact(inputCourseInfo.StartDate, STRING_DATE_FORMAT, CultureInfo.InvariantCulture),
                    EndDate = DateTime.ParseExact(inputCourseInfo.EndDate, STRING_DATE_FORMAT, CultureInfo.InvariantCulture),
                    ExamDate = DateTime.ParseExact(inputCourseInfo.ExamDate, STRING_DATE_FORMAT, CultureInfo.InvariantCulture),
                    TeacherId = (int)inputCourseInfo.TeacherId,
                };

                data.Courses.Add(course);
                data.SaveChanges();
            }
        }

        private void ValidateCourseInfo(AdministratorCourseServiceModel course)
        {
            //TODO:
            //  1 - Validate Course Name
            //  2 - Validate Course ID

            bool isCourseExists = false;
            bool isTeacherExists = false;

            using (var data = new StudentSystemDbContext())
            {
                isCourseExists = data.Courses
                    .Any(x => x.Name == course.Name);
                
                isTeacherExists = data.Teachers
                    .Any(x => x.TeacherId == course.TeacherId);
            }

            if (isCourseExists)
            {
                throw new InvalidOperationException(COURSE_EXISTS_EXCEPTION);
            }
            if (!isTeacherExists)
            {
                throw new InvalidOperationException(TEACHER_DASNOT_EXISTS_EXCEPTION);
            }

            bool isValidStartDate = DateTime.TryParseExact(course.StartDate, 
                STRING_DATE_FORMAT, 
                CultureInfo.InvariantCulture, 
                DateTimeStyles.None, out _);

            if (!isValidStartDate)
            {
                throw new InvalidOperationException(string.Format(INVALID_START_DATE_EXCEPTION, course.StartDate));
            }

            bool isValidEndDate = DateTime.TryParseExact(course.EndDate,
                STRING_DATE_FORMAT,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out _);

            if (!isValidEndDate)
            {
                throw new InvalidOperationException(string.Format(INVALID_END_DATE_EXCEPTION, course.EndDate));
            }

            bool isValidExamDate = DateTime.TryParseExact(course.ExamDate,
                STRING_DATE_FORMAT,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out _);

            if (!isValidExamDate)
            {
                throw new InvalidOperationException(string.Format(INVALID_EXAM_DATE_EXCEPTION, course.ExamDate));
            }
        }
    }
}
