using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject1.Models
{
    public class EFTimeslotRepo : ITimeslotRepo
    {
        private TimeslotDbContext _context;

        public EFTimeslotRepo (TimeslotDbContext context)
        {
            _context = context;
        }

        public IQueryable<Timeslot> Times => _context.Times;
    }
}