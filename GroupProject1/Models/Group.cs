using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GroupProject1.Models
{
    //This is the model that will be used for the group data that is stored in the database
	public class Group
    {
		[Key]
		public int GroupId { get; set; }

		[Required]
		public string GroupName { get; set; }

        [Required]
        public int GroupSize { get; set; }

		[Required]
		public string Email { get; set; }

		public string PhoneNumber { get; set; }

    }
}