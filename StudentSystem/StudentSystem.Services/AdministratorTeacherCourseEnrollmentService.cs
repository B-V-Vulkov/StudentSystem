namespace StudentSystem.Services
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    using System.Globalization;

    using Data;
    using Data.Models;
    using Models;
    using Contracts;

    using static Common.GlobalConstants;
    using static Common.ExceptionMessage;
    using static Common.DataValidations;

    public class AdministratorTeacherCourseEnrollmentService : IAdministratorTeacherCourseEnrollmentService
    {
        public IList<string> GetCourses()
        {
            IList<string> courses;

            using (var data = new StudentSystemDbContext())
            {
                courses = data.Courses
                    .Select(x => string
                    .Concat(x.CourseId, "-", x.Name))
                    .ToList();
            }

            return courses;
        }

        public IList<string> GetTeachers()
        {
            IList<string> teachers;

            using (var data = new StudentSystemDbContext())
            {
                teachers = data.Teachers
                    .Select(x => string
                    .Concat(x.TeacherId, "-", x.User.FirstName, " ", x.User.MiddleName, " ", x.User.LastName))
                    .ToList();
            }

            return teachers;
        }

        public void SaveCourseEnrollment(string teacherName, string courseName)
        {
            ValidateCourseEnrollment(teacherName, courseName);

            int teacherId = int.Parse(teacherName.Split('-')[0]);
            int courseId = int.Parse(courseName.Split('-')[0]);

            using (var data = new StudentSystemDbContext())
            {
                Teacher teacher = data.Teachers
                    .FirstOrDefault(x => x.User.Teacher.TeacherId == teacherId);

                Course course = data.Courses
                    .FirstOrDefault(x => x.CourseId == courseId);

                teacher.Courses.Add(course);
                data.SaveChanges();
            }
        }

        private void ValidateCourseEnrollment(string teacherName, string courseName)
        {
            StringBuilder exceptionMessages = new StringBuilder();

            bool isValid = true;

            if (String.IsNullOrEmpty(teacherName))
            {
                exceptionMessages.AppendLine(TEACHER_WAS_NOT_SELECTED_EXCEPTION_MESSAGE);
                isValid = false;
            }

            if (String.IsNullOrEmpty(courseName))
            {
                exceptionMessages.AppendLine(COURSE_WAS_NOT_SELECTED_EXCEPTION_MESSAGE);
                isValid = false;
            }

            if (!isValid)
            {
                throw new InvalidOperationException(exceptionMessages.ToString());
            }
        }
    }
}
