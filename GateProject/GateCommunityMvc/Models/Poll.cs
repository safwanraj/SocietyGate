using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis.Options;
using System;

namespace GateCommunityMvc.Models
{
    public class Poll
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Question { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? societyId { get; set; }
        [ForeignKey("societyId")]
        public SocietyDetails SocietyDetails { get; set; }
        public bool Answered { get; set; }
        public int? residentid { get; set; }
        [ForeignKey("residentid")]
        public Tblresident Tblresident { get; set; }
        
        public List<Option> Options { get; set; }
    }
}
