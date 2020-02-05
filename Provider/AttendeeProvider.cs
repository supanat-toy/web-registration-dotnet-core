using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_registration.Context;
using web_registration.Models;

namespace web_registration.Providers
{
    public class AttendeeProvider
    {
        private readonly ApplicationDBContext _context;

        public AttendeeProvider(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/Teams
        public List<Attendee> GetAttendees()
        {
            List<Attendee> attendees = _context.Attendee.ToList();
            return attendees;
        }

        public Attendee GetAttendee(int code, string name)
        {
            Attendee attendee = null;
            if (code != null) {
                attendee = _context.Attendee.Where(x => x.code == code).FirstOrDefault();
            } else if (name != null) {
                attendee = _context.Attendee.Where(x => x.name == name).FirstOrDefault();
            }
            return attendee;
        }

        public List<Attendee> GetCheckedInAttendees()
        {
            List<Attendee> attendees = _context.Attendee.Where(x => x.isChecked).ToList();
            return attendees;
        }

        public Boolean Checkin(int code)
        {
            var attendee = _context.Attendee.Where(x => x.code == code).FirstOrDefault();
            attendee.isChecked = true;
            attendee.checkedDateTime = DateTime.Now;
            _context.SaveChanges();
            return true;
        }

        public Boolean UnCheckin(int code)
        {
            var attendee = _context.Attendee.Where(x => x.code == code).FirstOrDefault();
            attendee.isChecked = false;
            attendee.checkedDateTime = null;
            _context.SaveChanges();
            return true;
        }
    }
}