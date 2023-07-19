using Org.BouncyCastle.Bcpg;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace GateCommunityMvc.Models
{
    public class Entryexit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int eid { get; set; }
        public int? residentid { get; set; }
        [ForeignKey("residentid")]
        public Tblresident Tblresident { get; set; }

        public int? visitorid { get; set; }
        [ForeignKey("visitorid")]
        public Visitors Visitors { get; set; }
        public int? societyid { get; set; }
        [ForeignKey("societyid")]
        public SocietyDetails society { get; set; }
        
        public DateTime Entry { get; set; }
        public DateTime Exit { get; set; }
        public string vname { get; set; }
        public string type { get; set; }
        public string Applicationuserid { get; set; }
        [ForeignKey("Applicationuserid")]
        public ApplicationUser ApplicationUser { get; set; }

        

    }
}
