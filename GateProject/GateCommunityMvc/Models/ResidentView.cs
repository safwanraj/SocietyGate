using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GateCommunityMvc.Models
{
    public class ResidentView
    {
        [Required(ErrorMessage = "Please select society")]
        [Display(Name = "Society")]
        public int societyid { get; set; }
        [Required(ErrorMessage = "Please select society wing")]
        [Display(Name = "Wing detail")]
        public int wingid { get; set; }
        public int flatno { get; set; }
        [Required(ErrorMessage = "Please enter first name")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string firstname { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
        [Display(Name = "last Name")]
        [StringLength(50)]
        public string lastname { get; set; }
        [Required(ErrorMessage = "Please enter email address")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string email { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage = "Please enter confirm password")]
        [Display(Name = "Confirm Password")]
        [Compare("password", ErrorMessage = "Password and confirm password does not match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please enter phone number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string phoneNumber { get; set; }
        [Required(ErrorMessage = "Please select gender")]
        [Display(Name = "Gender")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Please enter Document type")]
        [Display(Name = "Document type")]
        public string doc_type { get; set; }

        public List<SelectListItem> SocietyDetails { get; set; }
        public List<SelectListItem>  wingmodels { get; set; }
        public List<SelectListItem> flatmodels { get; set; }
    }
}
