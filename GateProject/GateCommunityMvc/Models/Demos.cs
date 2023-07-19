using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GateCommunityMvc.Models
{
	public class Demos
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Contact { get; set; }
		public string Email { get; set; }
		public string Societyname { get; set; }
		public string city { get; set; }
		public string role { get; set; }


	}
}
