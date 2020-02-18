using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_registration.Context;
using web_registration.Models;

namespace web_registration.Providers
{
    public class TeamProvider : ITeamProvider
    {
        private readonly ApplicationDBContext _context;
        private readonly IAttendeeProvider _attendeeProvider;

        public TeamProvider(ApplicationDBContext context,
                            IAttendeeProvider attendeeProvider)
        {
            _context = context;
            _attendeeProvider = attendeeProvider;
        }

        // GET: api/Teams

        public List<Team> GetTeams() {
            List<Team> teams = _context.Team.OrderBy(x => x.id).ToList();
            return teams;
        }

        public Boolean Vote(string attendeeCode, int teamId) {
            var attendee = _attendeeProvider.GetAttendee(attendeeCode, null);
            if (attendee == null) {
                return false;
            }
            attendee.voteTeamId = teamId;
            _context.SaveChanges();

            return true;
        }

        public List<TeamViewModel> GetSummaryScoreTeams() {
            var attendees = _attendeeProvider.GetAttendees().GroupBy(x => x.voteTeamId).Where(x => x.Key != null).ToList();
            var teams = GetTeams();

            var teamViewModels = new List<TeamViewModel>();
            foreach (var item in teams)
            {
                var attendeeGroupBy = attendees.Where(x => x.Key == item.id).FirstOrDefault();
                var amount = attendeeGroupBy == null ? 0 : attendeeGroupBy.Count();
                var newModel = new TeamViewModel() {
                    id = item.id,
                    code = item.code,
                    name = item.name,
                    division = item.division,
                    amount = amount
                };
                teamViewModels.Add(newModel);
            }
            return teamViewModels.OrderByDescending(x => x.amount).ToList();
        }
    }
}