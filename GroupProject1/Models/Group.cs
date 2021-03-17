using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GroupProject1.Models
{
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

		[RegularExpression(@"^\(?([0-9]{3}-)\)?[-. ]?([0-9]{3}-)[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
		public string PhoneNumber { get; set; }

    }
}