﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GroupProject1.Models
{
	public class Timeslot
	{
		[Key]
		public int TimeslotId { get; set; }

		[Required]
		public string Date { get; set; }

		[Required]
		public string Time { get; set; }

		[Required]
		public bool isBooked { get; set; } = false

	}
}