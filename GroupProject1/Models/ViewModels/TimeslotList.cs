using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject1.Models.ViewModels
{
    //Model for the timeslots
    public class TimeslotList
    {
        public IEnumerable<Timeslot> Times { get; set; }
    }
}
