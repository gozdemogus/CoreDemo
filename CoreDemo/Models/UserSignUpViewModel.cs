using System;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
	public class UserSignUpViewModel
	{
		public UserSignUpViewModel()
		{
		}

		[Display(Name ="Name Surname")]
		[Required(ErrorMessage ="Please fill Name Surname")]
		public string NameSurname { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please fill Password")]
        public string Password { get; set; }

        [Display(Name = "Password Again")]
        [Compare("Password", ErrorMessage = "Passwords must match")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Address")]
        [Required(ErrorMessage = "Please fill Mail")]
        public string Mail { get; set; }

        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Please fill Username")]
        public string UserName { get; set; }
    }
}

