using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GateCommunityMvc.Models
{
    public class Flatview
    {
        public int? wingid { get; set; }
        public int? flatid { get; set; }
        [Required(ErrorMessage = "Please enter floor no")]
        [Display(Name = "Enter Floor Number ")]
        public string floorno { get; set; }
        [Required(ErrorMessage = "Please enter flat number")]
        [Display(Name = " Flat  Number ")]
        public int flatno { get; set;}
        public List<SelectListItem> SocietyDetails { get; set; }
        public List<SelectListItem> wingmodels { get; set; }
    }
}
