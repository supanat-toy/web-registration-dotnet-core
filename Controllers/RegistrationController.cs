using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_registration.Context;
using web_registration.Models;
using web_registration.Providers;
// using System.Web.Script.Serialization;

// [Produces("application/json")]
// [Route("api/attendee")]

 // https://localhost:5001/swagger/index.html
namespace web_registration.Controllers
{
    public class RegistrationController : BaseController
    {
        private readonly ApplicationDBContext _context;
        private readonly IAttendeeProvider _attendeeProvider;
        
        public RegistrationController(ApplicationDBContext context, 
                                     IAttendeeProvider attendeeProvider) : base(context) {
            _attendeeProvider = attendeeProvider;
        } 

        public IActionResult Index(bool isError = false)
        {
            if (isError) {
                ViewData["isSuccess"] = false;
            }
            return View();
        }

        [HttpPost]
        public IActionResult Completion(Attendee model)
        {
            var isSuccess = _attendeeProvider.Checkin(model.code);

            if (isSuccess) {
                var attendee = _attendeeProvider.GetAttendee(model.code, null);
                ViewData["isSuccess"] = true;
                return View("Completion", attendee);
            } else {
                return Redirect("/registration?isError=true");
            }
        }
    }
}