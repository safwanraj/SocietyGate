using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GateCommunityMvc.Models
{
	public class Visitors
	{

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int visitorId { get; set; }
		public int? societyid { get; set; }
		[ForeignKey("societyid")]
		public SocietyDetails societyDetails { get; set; }
		public int? wingid { get; set; }
		[ForeignKey("wingid")]
		public Wingmodel Wingmodel { get; set; }
		public int? flatid { get; set; }
		[ForeignKey("flatid")]
		public Flatmodel Flatmodel { get; set; }
        public int? residentid { get; set; }
        [ForeignKey("residentid")]
        public Tblresident Tblresident { get; set; }
        public string visitorName { get; set; }
		public string visitorType { get; set; }
		public string workas { get; set; }
	    public string visitorcontact { get; set; }
		public string purposeofvisit { get; set; }
		public string aadharno { get; set; }
		public string from { get; set; }
		public string vehicleno { get; set; }
		
		public string profilepath { get; set; }
		public string doc_type { get; set; }
		public string status { get; set; }
		public string gender { get; set; }
		public string doc_name { get; set; }
		public string doc_path { get; set; }
		
		public string userid { get; set; }
		public ApplicationUser ApplicationUser { get; set; }


	}
}
