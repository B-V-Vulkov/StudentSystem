﻿namespace StudentSystem.Data.Models
{
    public class Administrator
    {
        public int AdministratorId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
