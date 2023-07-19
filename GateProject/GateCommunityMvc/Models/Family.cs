using System.ComponentModel.DataAnnotations.Schema;

namespace GateCommunityMvc.Models
{
    public class Family
    {
       
        public int FamilyId { get; set; }
        public string FamilyName { get; set;}
        public string relationship { get; set;}
        public string contact { get; set;}
        public string email { get; set;}
        public string filename { get; set; }
        public string filepath { get; set; }
        public string gender { get; set; }
       public string passcode { get; set; }
        public string status { get; set; }
        public int? residentid { get; set; }
        [ForeignKey("residentid")]
        public Tblresident Tblresident { get; set; }
       

    }
}
