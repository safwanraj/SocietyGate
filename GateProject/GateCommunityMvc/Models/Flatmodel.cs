using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GateCommunityMvc.Models
{
    public class Flatmodel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Flatid { get; set; }
      
        public string floorno { get; set; }
      
        public int flatno { get; set; }
       
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? SocietyId { get; set; }
        [ForeignKey("SocietyId")]
        public SocietyDetails SocietyDetails { get; set; }
        public int? WingId { get; set; }
        [ForeignKey("WingId")]
        public Wingmodel Wingmodel { get; set; }
        public string CurrentuserId { get; set; }
        [ForeignKey("CurrentuserId")]
        public ApplicationUser ApplicationUser { get; set; }
       




    }
}
