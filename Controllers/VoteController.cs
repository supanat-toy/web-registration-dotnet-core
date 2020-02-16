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
    public class VoteController : BaseController
    {
        private readonly ApplicationDBContext _context;
        private readonly IAttendeeProvider _attendeeProvider;
        private readonly ITeamProvider _teamProvider;

        [TempData]
        public bool? isSuccess { get; set; }

        public VoteController(ApplicationDBContext context, 
                                     IAttendeeProvider attendeeProvider,
                                     ITeamProvider teamProvider) : base(context) {
            _attendeeProvider = attendeeProvider;
            _teamProvider = teamProvider;
        } 

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Summary()
        {
            var summaryScoreTeams = _teamProvider.GetSummaryScoreTeams();
            return View(summaryScoreTeams);
        }

        [HttpPost] 
        public IActionResult Teams(Attendee model)
        {
            var attendee = _attendeeProvider.GetAttendee(model.code, null);
            var teams = _teamProvider.GetTeams();
            if (attendee != null) {
                ViewData["attendeeCode"] = attendee.code;
                return View("Teams", teams);
            } else {
                isSuccess = false;
                return Redirect("/vote");
            }
        }

        [HttpPost] 
        public IActionResult Completion(Attendee model)
        {
            if (model.voteTeamId == null) {
                return Redirect("/vote");
            }

            isSuccess = _teamProvider.Vote(model.code, model.voteTeamId ?? 0);
            if (isSuccess ?? false) {
                return View("Completion", model);
            } else {
                return Redirect("/vote");
            }
        }
    }
}