using System;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
	public class UserSignInViewModel
	{
		public UserSignInViewModel()
		{
		}

		[Required(ErrorMessage="Enter username")]
		public string username { get; set; }

        [Required(ErrorMessage = "Enter password")]
        public string password { get; set; }
	}
}

