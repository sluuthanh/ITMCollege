using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeAPI.Models
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int StreamId { get; set; }
        public int FieldId { get; set; }
        public string Image { get; set; }

        public virtual Field Field { get; set; }
        public virtual Stream Stream { get; set; }
    }
}
