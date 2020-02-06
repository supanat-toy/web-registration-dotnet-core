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
    public class RegistrationController : Controller
    {
        private readonly ApplicationDBContext _context;

        public RegistrationController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}