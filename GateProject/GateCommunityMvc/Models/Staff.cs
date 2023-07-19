using System.ComponentModel.DataAnnotations.Schema;

namespace GateCommunityMvc.Models
{
    public class Staff
    {
        public int staffId { get; set; }
        public string staffName { get; set;}
        public string email { get; set;}
        public string contact { get; set;}
        public string aadharno { get; set;}
        public string workas { get; set;}
        public string gender { get; set;}
        public string passcode { get; set;}
        public string status { get; set;}
        public string filename { get; set; }
        public string filepath { get; set; }
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
        public string userId { get; set; }
        [ForeignKey("userId")]
        public ApplicationUser Applicationuser { get; set; }

    }
}
