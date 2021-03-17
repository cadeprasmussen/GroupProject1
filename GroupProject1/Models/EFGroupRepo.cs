using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject1.Models
{
    public class EFGroupRepo : IGroupRepo
    {
        private GroupListContext _context;

        public EFGroupRepo (GroupListContext context)
        {
            _context = context;
        }

        public IQueryable<Group> Groups => _context.Groups;
        public IQueryable<Timeslot> Times => _context.Times;
    }
}