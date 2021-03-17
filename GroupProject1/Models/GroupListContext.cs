using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject1.Models
{
    public class GroupListContext : DbContext
    {
        public GroupListContext(DbContextOptions<GroupListContext> options) : base(options)
        {

        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Timeslot> Times { get; set; }
    }
}