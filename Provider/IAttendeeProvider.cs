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
    public interface IAttendeeProvider
    {
        List<Attendee> GetAttendees();
        Attendee GetAttendee(int code, string name);
        List<Attendee> GetCheckedInAttendees();
        Boolean Checkin(int code);
        Boolean UnCheckin(int code);
    }
}