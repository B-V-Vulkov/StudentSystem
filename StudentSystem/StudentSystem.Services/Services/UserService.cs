namespace StudentSystem.Services.Services
{
    using Models;
    using System;
    using System.Collections.Generic;

    public class UserService
    {
        public User GetUser(string userName, string password)
        {
            return new User();
        }

        public List<StudentCourses> GetCourses()
        {
            return new List<StudentCourses>()
            {
                new StudentCourses()
                {
                    Name = "Course1",
                    Teacher = "Pesho",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,
                    Result = 5.23,
                },
                new StudentCourses()
                {
                    Name = "Course2",
                    Teacher = "Gosho",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,
                    Result = 5.23,
                },
                new StudentCourses()
                {
                    Name = "Course3 Test",
                    Teacher = "Ivan",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,
                    Result = 5.23,
                },
                new StudentCourses()
                {
                    Name = "TestTestTest",
                    Teacher = "Gosho",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,
                    Result = 5.23,
                },
                new StudentCourses()
                {
                    Name = "Course1",
                    Teacher = "Pesho",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,
                    Result = 5.23,
                },
                new StudentCourses()
                {
                    Name = "Course2",
                    Teacher = "Gosho",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,
                    Result = 5.23,
                },
                new StudentCourses()
                {
                    Name = "Course3 Test",
                    Teacher = "Ivan",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,
                    Result = 5.23,
                },
                new StudentCourses()
                {
                    Name = "TestTestTest",
                    Teacher = "Gosho",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,
                    Result = 5.23,
                },
            };
        }
    }
}
