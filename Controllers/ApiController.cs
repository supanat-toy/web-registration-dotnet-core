using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_registration.Context;
using web_registration.Models;
// using System.Web.Script.Serialization;

// [Produces("application/json")]
// [Route("api/attendee")]

 // https://localhost:5001/swagger/index.html
namespace web_registration.Controllers
{
    [Route("attendee")]
    public class ApiController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ApiController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/Teams
        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> GetAttendees()
        {
            List<Attendee> attendees = _context.Attendee.ToList();
            return Ok(attendees);
        }

        [HttpGet]
        [Route("profile")]
        public async Task<IActionResult> GetAttendee(string code, string name)
        {
            Attendee attendee = null;
            if (code != null) {
                attendee = _context.Attendee.Where(x => x.code == code).FirstOrDefault();
            } else if (name != null) {
                attendee = _context.Attendee.Where(x => x.nameEN == name).FirstOrDefault();
            }
            return Ok(attendee);
        }

        [HttpGet]
        [Route("checked-list")]
        public async Task<IActionResult> GetCheckedInAttendees()
        {
            List<Attendee> attendees = _context.Attendee.Where(x => x.isChecked ?? false).ToList();
            return Ok(attendees);
        }

        [HttpPost]
        [Route("check-in")]
        public async Task<IActionResult> Checkin(string code)
        {
            var attendee = _context.Attendee.Where(x => x.code == code).FirstOrDefault();
            attendee.isChecked = true;
            attendee.checkedDateTime = DateTime.Now;
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        [Route("uncheck-in")]
        public async Task<IActionResult> UnCheckin(string code, string name)
        {
            var attendee = _context.Attendee.Where(x => x.code == code).FirstOrDefault();
            attendee.isChecked = false;
            attendee.checkedDateTime = null;
            _context.SaveChanges();
            return Ok();
        }
    }
}