using CalendarSystem.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CalendarSystem.Domain
{
    public class MyContext : DbContext
    {
        public DbSet<Month> months { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        public MyContext() : base("Myconn")
        {

        }
    }
}
