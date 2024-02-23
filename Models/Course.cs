using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Group3.Models
{
    public partial class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }
        public string Picture { get; set; }
        public int? TotalTime { get; set; }
        public decimal? Price { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }

        public virtual Category Category { get; set; }
    }
}
