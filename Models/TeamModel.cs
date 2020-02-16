using System;
using System.ComponentModel.DataAnnotations;

namespace web_registration.Models
{
    public class Team
    {
        [Key]
        public int id { get; set; }
        
        public int code { get; set; }

        public string name { get; set; }
    }

    public class TeamViewModel
    {
        public int id { get; set; }
        
        public int code { get; set; }

        public string name { get; set; }

        public int amount { get; set; }
    }
}