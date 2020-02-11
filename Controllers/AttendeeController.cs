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
    public class AttendeeController : BaseController
    {
        private readonly IAttendeeProvider _attendeeProvider;
        
        public AttendeeController(ApplicationDBContext context, 
                                 IAttendeeProvider attendeeProvider) : base(context) {
            _attendeeProvider = attendeeProvider;
        } 

        public IActionResult Index()
        {
            List<Attendee> attendees = _attendeeProvider.GetAttendees(); //_context.Attendee.ToList();
            return View(attendees);
        }

        public IActionResult Checkin(int code)
        {
            _attendeeProvider.Checkin(code);

            return Redirect("/attendee");
        }

        public IActionResult UnCheckin(int code)
        {
            _attendeeProvider.UnCheckin(code);

            return Redirect("/attendee");
        }
    }
}
