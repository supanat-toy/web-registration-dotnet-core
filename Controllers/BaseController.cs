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
    public class BaseController : Controller
    {
        protected readonly ApplicationDBContext _context;

        public BaseController(ApplicationDBContext context)
        {
            _context = context;
        }
    }
}
