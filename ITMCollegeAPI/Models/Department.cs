using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeAPI.Models
{
    public partial class Department
    {
        public Department()
        {
            Faculties = new HashSet<Faculty>();
        }

        public int DepId { get; set; }
        public string DepName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Faculty> Faculties { get; set; }
    }
}
