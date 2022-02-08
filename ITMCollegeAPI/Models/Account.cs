using System;
using System.Collections.Generic;

#nullable disable

namespace ITMCollegeAPI.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte Role { get; set; }
        public bool IsActive { get; set; }
    }
}
