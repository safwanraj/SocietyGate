using System.ComponentModel.DataAnnotations;

namespace GateCommunityMvc.Models
{
    public class Staffview
    {
        [Required(ErrorMessage = "Please enter Staff full name")]
        [Display(Name = "Staff Full Name")]
        [StringLength(100)]
        public string staffName { get; set; }
        [Required(ErrorMessage = "Please enter email address")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string email { get; set; }
        [Required(ErrorMessage = "Please enter phone number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string contact { get; set; }
        [Required(ErrorMessage = "Please enter aadhar number")]
        [Display(Name = "Aadhar Number")]
        public string aadharno { get; set; }
        [Required(ErrorMessage = "Please enter work type")]
        [Display(Name = "Work as")]
        public string workas { get; set; }
        public string gender { get; set; }
    }
}
