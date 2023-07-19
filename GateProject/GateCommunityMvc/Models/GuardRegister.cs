using System.ComponentModel.DataAnnotations;

namespace GateCommunityMvc.Models
{
    public class GuardRegister
    {

        [Required(ErrorMessage = "Please enter Guard full name")]
        [Display(Name ="Guard Full Name")]
        [StringLength(100)]
        public string Guard_FullName { get; set; }
        [Required(ErrorMessage = "Please enter email address")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Guard_Email { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Guard_Password { get; set; }
        [Required(ErrorMessage = "Please enter phone number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string Guard_Contact { get; set; }
        [Display(Name = "Alternate Phone Number")]
        public string alternate_contact { get; set; }
        [Required(ErrorMessage = "Please enter Gender detail")]
        [Display(Name = "Gender")]
        public string Guard_Gender { get; set; }
        public bool Is_active { get; set; }
        [Required(ErrorMessage = "Please enter job detail")]
        [Display(Name = "Job Position")]
        public string Job_position { get; set; }
        [Required(ErrorMessage = "Please enter Document type")]
        [Display(Name = "Document type")]
        public string doc_type { get; set; }
    }
}
