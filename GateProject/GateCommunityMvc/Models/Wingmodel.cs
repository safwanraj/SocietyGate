using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace GateCommunityMvc.Models
{
    public class Wingmodel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        [Required(ErrorMessage = "wing name required")]
        [Display(Name = "Enter Wing Name ")]
        public string WingName { get; set; }
        [Required(ErrorMessage = "no of floors required")]
        [Display(Name = "Enter No. of Floors ")]
        public string nooffloors { get; set; }
        public int Society_Id { get; set; }
        [ForeignKey("Society_Id")]
        public SocietyDetails SocietyDetails { get; set; }
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<Tblresident> Tblresidents { get; set;}
        public List<Flatmodel> Flatmodels { get; set;}
    }
}
