using System.ComponentModel.DataAnnotations.Schema;

namespace GateCommunityMvc.Models
{
    public class Vehicle
    {
        public int vehicleid { get; set; }
        public string vehicleno { get; set; }
        public string vehicletype { get; set; }
        public string manufacturer { get; set; }
        public int? residentid { get; set; }
        [ForeignKey("residentid")]
        public Tblresident Tblresident { get; set; }
        public int? societyid { get; set; }
        [ForeignKey("societyid")]
        public SocietyDetails SocietyDetails { get; set; }
        public int? wingid { get; set; }
        [ForeignKey("wingid")]
        public Wingmodel Wingmodel { get; set; }
        public int? flatid { get; set; }
        [ForeignKey("flatid")]
        public Flatmodel Flatmodel { get; set; }
    }
}
