using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeAPI.Models
{
    public partial class OpSubject
    {
        public OpSubject()
        {
            Registrations = new HashSet<Registration>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
