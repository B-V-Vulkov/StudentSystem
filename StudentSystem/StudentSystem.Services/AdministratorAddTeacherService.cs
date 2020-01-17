namespace StudentSystem.Services
{
    using Contracts;
    using StudentSystem.Data;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using static Common.GlobalConstants;
    using static Common.ExceptionMessage;
    using static Common.DataValidations;
    using System;

    public class AdministratorAddTeacherService : IAdministratorAddTeacherService
    {
        public void AddTeacher(AdministratorAddTeacherServiceModel teacher)
        {
            ValidateTeacherInfo(teacher);

            using (var data = new StudentSystemDbContext())
            {
                bool isTownExists = data.Towns
                    .Any(x => x.Name == teacher.Town);

                if (!isTownExists)
                {
                    data.Towns.Add(new Town()
                    {
                        Name = teacher.Town,
                    });
                }

                Town town = data.Towns
                    .FirstOrDefault(x => x.Name == teacher.Town);

                Department department = data.Departments
                   .FirstOrDefault(x => x.Name == teacher.Department);

                User user = new User()
                {
                    UserName = string.Format(DEFAULT_USERNAME, teacher.FirstName),
                    Password = DEFAULT_PASSWORD,
                    FirstName = teacher.FirstName,
                    MiddleName = teacher.MiddleName,
                    LastName = teacher.LastName,
                    Town = town,
                    Department = department,
                };

                Teacher AddTeacher = new Teacher()
                {
                    User = user,
                };

                data.Users.Add(user);
                data.Teachers.Add(AddTeacher);
                data.SaveChanges();
            }
        }

        public IList<string> GetDepartments()
        {
            IList<string> departments;

            using (var data = new StudentSystemDbContext())
            {
                departments = data.Departments
                    .Select(x => x.Name)
                    .ToList();
            }

            return departments;
        }

        private void ValidateTeacherInfo(AdministratorAddTeacherServiceModel teacher)
        {
            StringBuilder exceptionMessages = new StringBuilder();

            bool isValid = true;

            if (teacher.FirstName == null ||
                teacher.FirstName.Length < USER_FIRST_NAME_MIN_LENGTH || 
                teacher.FirstName.Length > USER_FIRST_NAME_MAX_LENGTH)
            {
                exceptionMessages.AppendLine(INVALID_USER_FIRST_NAME_LENGTH_EXCEPTION_MESSAGE);
                isValid = false;
            }

            if (teacher.MiddleName == null ||
                teacher.MiddleName.Length < USER_MIDDLE_NAME_MIN_LENGTH ||
                teacher.MiddleName.Length > USER_MIDDLE_NAME_MAX_LENGTH)
            {
                exceptionMessages.AppendLine(INVALID_USER_MIDDLES_NAME_LENGTH_EXCEPTION_MESSAGE);
                isValid = false;
            }

            if (teacher.LastName == null ||
                teacher.LastName.Length < USER_LAST_NAME_MIN_LENGTH ||
                teacher.LastName.Length > USER_LAST_NAME_MAX_LENGTH)
            {
                exceptionMessages.AppendLine(INVALID_USER_LAST_NAME_LENGTH_EXCEPTION_MESSAGE);
                isValid = false;
            }

            if (teacher.Town == null ||
                teacher.Town.Length < TOWN_NAME_MIN_LENGTH ||
                teacher.Town.Length > TOWN_NAME_MAX_LENGTH)
            {
                exceptionMessages.AppendLine(INVALID_TOWN_NAME_LENGTH_EXCEPTION_MESSAGE);
                isValid = false;
            }

            if (!isValid)
            {
                throw new InvalidOperationException(exceptionMessages.ToString());
            }
        }
    }
}
