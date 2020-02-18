using System;
using System.Web;
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
        
        [TempData]
        public string errorMessage { get; set; }

        public RegistrationController(ApplicationDBContext context, 
                                     IAttendeeProvider attendeeProvider) : base(context) {
            _attendeeProvider = attendeeProvider;
        } 

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult Completion(Attendee model)
        {
            var attendee = _attendeeProvider.GetAttendee(model.code, null);

            if (attendee == null) {
                errorMessage = "ไม่พบรหัสพนักงาน";
                return Redirect("/registration");
            } else if (attendee.isChecked ?? false) {
                errorMessage = "ลงชื่อเข้าร่วมงานแล้ว";
                return Redirect("/registration");
            } else {
                _attendeeProvider.Checkin(model.code);
                return View("Completion", attendee);
            }
        }
    }
}