using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject1.Models
{
    public class TimeslotDbContext : DbContext
    {
        public TimeslotDbContext(DbContextOptions<TimeslotDbContext> options) : base(options)
        {
            ll
        }

        public DbSet<Timeslot> Times { get; set; }
    }
}