using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_registration.Context;
using web_registration.Models;

namespace web_registration.Providers
{
    public class AttendeeProvider : IAttendeeProvider
    {
        private readonly ApplicationDBContext _context;

        public AttendeeProvider(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/Teams
        public List<Attendee> GetAttendees()
        {
            List<Attendee> attendees = _context.Attendee.OrderBy(x => x.code).ToList();
            return attendees;
        }

        public Attendee GetAttendee(string code, string name)
        {
            Attendee attendee = null;
            if (code != null) {
                attendee = _context.Attendee.Where(x => x.code == code).FirstOrDefault();
            } else if (name != null) {
                attendee = _context.Attendee.Where(x => x.nameEN == name).FirstOrDefault();
            }
            return attendee;
        }

        public List<Attendee> GetCheckedInAttendees()
        {
            List<Attendee> attendees = _context.Attendee.Where(x => x.isChecked ?? false).ToList();
            return attendees;
        }

        public Boolean Checkin(string code)
        {
            var attendee = _context.Attendee.Where(x => x.code == code).FirstOrDefault();
            if (attendee == null) {
                return false;
            }
            attendee.isChecked = true;
            attendee.checkedDateTime = DateTime.Now;
            _context.SaveChanges();
            return true;
        }

        public Boolean UnCheckin(string code)
        {
            var attendee = _context.Attendee.Where(x => x.code == code).FirstOrDefault();
            if (attendee == null) {
                return false;
            }
            attendee.isChecked = false;
            attendee.checkedDateTime = null;
            _context.SaveChanges();
            return true;
        }
    }
}