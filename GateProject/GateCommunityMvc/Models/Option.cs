using System.ComponentModel.DataAnnotations.Schema;

namespace GateCommunityMvc.Models
{
    public class Option
    {
        public int Id { get; set; }
        public int PollId { get; set; }
        [ForeignKey("PollId")]
        public Poll Poll { get; set; }
        public string OptionText { get; set; }
        public int VotesCount { get; set; }
        public int? societyId { get; set; }
        [ForeignKey("societyId")]
        public SocietyDetails SocietyDetails { get; set; }
        
    }
}
