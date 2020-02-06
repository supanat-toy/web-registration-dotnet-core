using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_registration.Context;
using web_registration.Models;
using web_registration.Providers;

namespace web_registration.Controllers
{
    public class AttendeeController : Controller
    {
        private readonly ApplicationDBContext _context;
        
        public AttendeeController(ApplicationDBContext context) {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Attendee> attendees = _context.Attendee.ToList();
            return View(attendees);
        }

        public IActionResult Checkin(int code)
        {
            var attendee = _context.Attendee.Where(x => x.code == code).FirstOrDefault();
            attendee.isChecked = true;
            attendee.checkedDateTime = DateTime.Now;
            _context.SaveChanges();

            return Redirect("/attendee");
        }

        public IActionResult UnCheckin(int code)
        {
            var attendee = _context.Attendee.Where(x => x.code == code).FirstOrDefault();
            attendee.isChecked = false;
            attendee.checkedDateTime = null;
            _context.SaveChanges();

            return Redirect("/attendee");
        }
    }
}
