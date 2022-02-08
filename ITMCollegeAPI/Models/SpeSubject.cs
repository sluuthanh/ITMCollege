using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeAPI.Models
{
    public partial class SpeSubject
    {
        public SpeSubject()
        {
            Registrations = new HashSet<Registration>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int FieldId { get; set; }

        public virtual Field Field { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
