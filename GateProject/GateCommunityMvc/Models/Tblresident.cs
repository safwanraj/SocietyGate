using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace GateCommunityMvc.Models
{
    public class Tblresident
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int residentId { get; set; }
        public int? societyid { get; set; }
        [ForeignKey("societyid")]
        public SocietyDetails SocietyDetails { get; set; }
        public int? wingid { get; set; }
        [ForeignKey("wingid")]
        public Wingmodel Wingmodel { get; set; }
        public int? flatno { get; set; }
		[ForeignKey("flatno")]
		public Flatmodel Flatmodel { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phoneNumber { get; set; }
        public string gender { get; set; }
        public string status { get; set; }
        public string doc_type { get; set; }
        public string Idfile_name { get; set; }
        public string Idfile_Path { get; set; }
        public string profilepath { get; set; }
        public string gatepasscode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


    }
}
