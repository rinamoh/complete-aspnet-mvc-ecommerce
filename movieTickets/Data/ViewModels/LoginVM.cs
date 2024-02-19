using System.ComponentModel.DataAnnotations;

namespace movieTickets.Data.ViewModels
{
	public class LoginVM
	{
		[Display(Name = "Email Adress")]
		[Required(ErrorMessage="Email Adress is Required")]
		public string EmailAddress { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
