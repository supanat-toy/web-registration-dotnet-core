using System;
using System.ComponentModel.DataAnnotations;

namespace web_registration.Models
{
    public class Attendee
    {
        [Key]
        public int code { get; set; }

        public string nameTH { get; set; }
        public string nameEN { get; set; }

        public bool? isChecked { get; set; }

        public DateTime? checkedDateTime { get; set; }
    }
}