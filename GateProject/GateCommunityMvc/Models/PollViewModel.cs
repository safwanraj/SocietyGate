using System.Collections.Generic;
using System;

namespace GateCommunityMvc.Models
{
    public class PollViewModel
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public List<string> OptionTexts { get; set; }
        public List<int> Votes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Option> Options { get; set; } = new List<Option>();
    }
}
