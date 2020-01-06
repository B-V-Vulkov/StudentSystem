using System;

namespace StudentSystem.Services.Models
{
    public class StudentCourses
    {
        public string Name { get; set; }

        public string Teacher { get; set; }

        public DateTime ExamDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double Result { get; set; }
    }
}
