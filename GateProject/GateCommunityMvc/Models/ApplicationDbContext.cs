using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GateCommunityMvc.Models
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{

		
		
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		

		public DbSet<SocietyDetails> Societies { get; set; }
		public DbSet<Wingmodel> Wingmodels { get; set;}

		public DbSet<Flatmodel> Flats { get; set; }	
		public DbSet<Security_Guard> Security_Guards { get; set;}
		public DbSet<Tblresident> tblResidents { get; set;}
		public DbSet<Demos> demos { get; set; }
		public DbSet<Visitors> visitors { get; set; }
		public DbSet<Family> familys { get; set; }
		public DbSet<Staff> staffs { get; set; }
		public DbSet<Vehicle> vehicles { get; set; }
		public DbSet<Entryexit> entryexits { get; set; }
		public DbSet<Announcement> announcements { get; set; }
		public DbSet<Poll> Polls { get; set; }
		public DbSet<Option> Option { get; set; }
		
       

    }
}
