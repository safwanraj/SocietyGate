using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GateCommunityMvc.Models
{
    public class Visitorview
    {
       
        public int residentid { get; set; }
        [Required(ErrorMessage = "Please enter visitors full name")]
        [Display(Name = "Visitor Full Name")]
        [StringLength(100)]
        public string visitorName { get; set; }
        [Required(ErrorMessage = "type of visitor")]
        [Display(Name = "Visitor Type")]
        public string visitorType { get; set; }
        [Required(ErrorMessage = "Work as")]
        [Display(Name = "Work as")]
        public string workas { get; set; }
        [Required(ErrorMessage = "Please enter phone number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string visitorcontact { get; set; }
        [Required(ErrorMessage = "Purpose of visit")]
        [Display(Name = "Purpose of visit")]
        public string purposeofvisit { get; set; }
        [Required(ErrorMessage = "please enter aadhar number")]
        [Display(Name = "Aadhar Number")]
        public string aadharno { get; set; }
        [Required(ErrorMessage = "visitor came from")]
        [Display(Name = "From")]
        public string from { get; set; }
        [Required(ErrorMessage = "Enter vehicle number")]
        [Display(Name = "Vehicle Number")]
        public string vehicleno { get; set; }
        [Required(ErrorMessage = "Document Type")]
        [Display(Name = "Document Type")]
        public string doc_type { get; set; }
        public int wingid { get; set; }
        public string gender { get; set; }
        public int flatid { get; set; }
        public string profilepath { get; set; }
        public string docpath { get; set; }
        public string docname { get; set; }
        public List<SelectListItem> resident { get; set; }

    }
}
