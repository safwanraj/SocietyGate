using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace GateCommunityMvc.Models
{
	public class SocietyDetails
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Society_Id { get; set; }
		public string Society_Name { get; set; }
		public string Description { get; set; }
		public string President_Name { get; set; }
		public string Gender { get; set; }
		public string Contact { get; set; }
		public string Address { get; set; }
		public string Country { get; set; }
		public string State { get; set; }
		public string City { get; set; }
		public string Postal_Code { get; set; }
		public string status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string ApplicationUserId { get; set; }
		public ApplicationUser ApplicationUser { get; set; }
		public string AdminID { get; set; }
		public ApplicationUser Admin { get; set; }

        public List<Wingmodel> wingmodels { get; set; }
        public List<Flatmodel> flatmodels { get; set; }


    }
}
