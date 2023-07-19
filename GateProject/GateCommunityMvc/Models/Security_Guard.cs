using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GateCommunityMvc.Models
{
    public class Security_Guard
    {
        [Key]
        public int Guard_Id { get; set; }
        public string Guard_FullName { get; set; }
       
        public string Guard_Contact { get; set; }
        public string alternate_contact { get; set; }
        public string Guard_Gender { get; set; }
        public string status { get; set; }
        public string Job_position { get; set; }

       public string doc_type { get; set; }
        public string Idfile_name { get; set; }
        
        public string Idfile_Path { get; set; }
        public string profilepath { get; set; }
        
        public int? Societyid { get; set; }
        [ForeignKey("Societyid")]
        public SocietyDetails SocietyDetails { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string currentuserid { get; set; }
        [ForeignKey("currentuserid")]
        public ApplicationUser CurrentuseId { get; set; }
        public DateTime createddate { get; set; }
        public DateTime updateddate { get; set; }




    }
}
