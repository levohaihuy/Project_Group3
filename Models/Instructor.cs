﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Group3.Models
{
    public partial class Instructor
    {
        public string InstructorId { get; set; }
        public decimal? Income { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Picture { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? Status { get; set; }
    }
}
