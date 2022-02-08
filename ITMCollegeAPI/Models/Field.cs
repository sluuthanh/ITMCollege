using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeAPI.Models
{
    public partial class Field
    {
        public Field()
        {
            Admissions = new HashSet<Admission>();
            Courses = new HashSet<Course>();
            SpeSubjects = new HashSet<SpeSubject>();
        }

        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public int StreamId { get; set; }

        public virtual Stream Stream { get; set; }
        public virtual ICollection<Admission> Admissions { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<SpeSubject> SpeSubjects { get; set; }
    }
}
