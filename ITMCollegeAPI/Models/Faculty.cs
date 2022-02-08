using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeAPI.Models
{
    public partial class Faculty
    {
        public int FacultyId { get; set; }
        public string FalcultyName { get; set; }
        public DateTime Dob { get; set; }
        public string Degree { get; set; }
        public int DepId { get; set; }
        public string Image { get; set; }

        public virtual Department Dep { get; set; }
    }
}
