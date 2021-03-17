using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject1.Models
{
    public interface IGroupRepo
    {
        IQueryable<Group> Groups { get; }
        IQueryable<Timeslot> Times { get;  }
    }
}