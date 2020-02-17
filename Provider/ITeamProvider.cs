using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_registration.Context;
using web_registration.Models;

namespace web_registration.Providers
{
    public interface ITeamProvider
    {
        List<Team> GetTeams();
        Boolean Vote(string attendeeCode, int teamId);
        List<TeamViewModel> GetSummaryScoreTeams();
    }
}