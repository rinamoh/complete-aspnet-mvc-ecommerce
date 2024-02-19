using System.ComponentModel.DataAnnotations;

namespace movieTickets.Data.ViewModels
{
	public class RegisterVM
	{
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "FullName is Required")]
        public string FullName { get; set; }

        [Display(Name = "Email Adress")]
		[Required(ErrorMessage="Email Adress is Required")]
		public string EmailAddress { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

    }
}

