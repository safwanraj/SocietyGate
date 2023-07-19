using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GateCommunityMvc.Models
{
    public class Announcement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
       
        public DateTime PostedDate { get; set; }
        public int? societyid { get ; set; }
        [ForeignKey("societyid")]
        public SocietyDetails societydetails { get; set; }
    }
}
