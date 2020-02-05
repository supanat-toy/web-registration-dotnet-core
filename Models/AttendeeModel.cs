using System;
using System.ComponentModel.DataAnnotations;

namespace web_registration.Models
{
    public class Attendee
    {
        [Key]
        public int code { get; set; }

        public string name { get; set; }

        public Boolean isChecked { get; set; }

        public DateTime? checkedDateTime { get; set; }
    }
}