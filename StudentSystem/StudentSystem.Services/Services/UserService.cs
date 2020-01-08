namespace StudentSystem.Services.Services
{
    using Models;
    using System;
    using System.Collections.Generic;

    public class UserService
    {
        public UserModel GetUser(string userName, string password)
        {
            return new UserModel();
        }

        private List<StudentCourses> courses = new List<StudentCourses>()
        {
            new StudentCourses()
                {
                    Name = "Course1",
                    Teacher = "Pesho",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,

                },
                new StudentCourses()
                {
                    Name = "Course2",
                    Teacher = "Gosho",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,

                },
                new StudentCourses()
                {
                    Name = "Course3 Test",
                    Teacher = "Ivan",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,

                },
                new StudentCourses()
                {
                    Name = "TestTestTest",
                    Teacher = "Gosho",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,

                },
                new StudentCourses()
                {
                    Name = "Course1",
                    Teacher = "Pesho",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,

                },
                new StudentCourses()
                {
                    Name = "Course2",
                    Teacher = "Gosho",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,

                },
                new StudentCourses()
                {
                    Name = "Course3 Test",
                    Teacher = "Ivan",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,

                },
                new StudentCourses()
                {
                    Name = "TestTestTest",
                    Teacher = "Gosho",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    ExamDate = DateTime.Now,

                },
        };

        public void Save(List<StudentCourses> courses)
        {
            this.courses = courses;
        }

        public List<StudentCourses> GetCourses()
        {
            return this.courses;
        }

    }
}
