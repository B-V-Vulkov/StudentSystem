namespace StudentSystem.Services
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Globalization;

    using Data;
    using Data.Models;
    using Models;
    using Contracts;

    using static Common.GlobalConstants;
    using static Common.ExceptionMessage;
    using static Common.DataValidations;

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
                };

                data.Courses.Add(course);
                data.SaveChanges();
            }
        }

        private void ValidateCourseInfo(AdministratorCourseServiceModel course)
        {
            StringBuilder exceptionMessages = new StringBuilder();

            bool isValid = true;

            using (var data = new StudentSystemDbContext())
            {
                bool isCourseExists = data.Courses
                    .Any(x => x.Name == course.Name);

                if (isCourseExists)
                {
                    exceptionMessages.AppendLine(string.Format(COURSE_EXISTS_EXCEPTION_MESSAGE, course.Name));
                    isValid = false;
                }
            }

            if (course.Name == null || course.Name.Length < COURSE_NAME_MIN_LENGTH || course.Name.Length > COURSE_NAME_MAX_LENGTH)
            {
                exceptionMessages.AppendLine(INVALID_COURSE_NAME_LENGTH_EXCEPTION_MESSAGE);
                isValid = false;
            }

            bool isValidStartDate = DateTime.TryParseExact(course.StartDate, 
                STRING_DATE_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);

            if (!isValidStartDate)
            {
                exceptionMessages.AppendLine(string.Format(INVALID_START_DATE_EXCEPTION_MESSAGE, course.StartDate));
                isValid = false;
            }

            bool isValidEndDate = DateTime.TryParseExact(course.EndDate,
               STRING_DATE_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);

            if (!isValidEndDate)
            {
                exceptionMessages.AppendLine(string.Format(INVALID_END_DATE_EXCEPTION_MESSAGE, course.EndDate));
                isValid = false;
            }

            bool isValidExamDate = DateTime.TryParseExact(course.ExamDate,
                STRING_DATE_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);

            if (!isValidExamDate)
            {
                exceptionMessages.AppendLine(string.Format(INVALID_EXAM_DATE_EXCEPTION_MESSAGE, course.ExamDate));
                isValid = false;
            }

            if (!isValid)
            {
                throw new InvalidOperationException(exceptionMessages.ToString());
            }
        }
    }
}
