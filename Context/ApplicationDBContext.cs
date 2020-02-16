using System;
using Microsoft.EntityFrameworkCore;
using web_registration.Models;

namespace web_registration.Context
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Attendee> Attendee { get; set; }
        public DbSet<Team> Team { get; set; }
    }
}