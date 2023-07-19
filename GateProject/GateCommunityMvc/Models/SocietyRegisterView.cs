using System.ComponentModel.DataAnnotations;

namespace GateCommunityMvc.Models
{
	public class SocietyRegisterView
	{
		[Required(ErrorMessage = "Please enter society name")]
		[StringLength(100)]
		public string Society_Name { get; set; }
		public string Description { get; set; }

		[Required(ErrorMessage = "Please enter email address")]
		[Display(Name = "Email Address")]
		[EmailAddress]
		public string Email { get; set; }
		[Required(ErrorMessage = "Please enter password")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required(ErrorMessage = "Please enter confirm password")]
		[Display(Name = "Confirm Password")]
		[Compare("Password", ErrorMessage = "Password and confirm password does not match")]
		public string ConfirmPassword { get; set; }

		[Required(ErrorMessage = "Please enter name")]
		[StringLength(100)]
		public string President_Name { get; set; }
        [Required(ErrorMessage = "Please enter Gender")]
       
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter phone number")]
		[Display(Name = "Phone Number")]
		[Phone]
		public string Contact { get; set; }
        [Required(ErrorMessage = "Please enter Address")]
        [Display(Name = "Address")]
        public string Address { get; set; }
		[Required(ErrorMessage = "Country is required.")]
		public string Country { get; set; }
		[Required(ErrorMessage = "State is required.")]
		public string State { get; set; }
		[Required(ErrorMessage = "City is required.")]
		public string City { get; set; }
		[Required(ErrorMessage = "Postal Code is required.")]
		[RegularExpression(@"^\d{6}$", ErrorMessage = "Invalid Postal Code. Postal Code should be six digits.")]
		public string Postal_Code { get; set; }
		public bool isActive { get; set; }
	}
}
