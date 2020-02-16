using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace web_registration.Models
{
    public class Attendee
    {
        public int id { get; set; }
        [Key]
        public int code { get; set; }
        public string nameTH { get; set; }
        public string nameEN { get; set; }
        public bool? isChecked { get; set; }
        public DateTime? checkedDateTime { get; set; }
        public int? voteTeamId { get; set; }
    }

    public class LotteryAttendeeViewModel
    {
        public string name { get; set; }
        public List<Attendee> attendees { get; set; }
    }
}