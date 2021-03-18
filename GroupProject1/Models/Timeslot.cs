using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GroupProject1.Models
{
	//This is the model that will be used for the timeslot data in the database
	public class Timeslot
	{
		[Key]
		public int TimeslotId { get; set; }

		[Required]
		[DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]
		public DateTime Date { get; set; }

		[Required]
		public bool isBooked { get; set; } = false;
	}
}