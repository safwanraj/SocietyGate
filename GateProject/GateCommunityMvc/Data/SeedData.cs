using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace GateCommunityMvc.Data
{
	public static class SeedData
	{
		public static async Task Initialize(IServiceProvider serviceProvider)
		{
			var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

			await CreateRole(roleManager, "Admin");
			await CreateRole(roleManager, "President");
			await CreateRole(roleManager, "Resident");
			await CreateRole(roleManager, "Guard");
		}

		private static async Task CreateRole(RoleManager<IdentityRole> roleManager, string roleName)
		{
			if (!await roleManager.RoleExistsAsync(roleName))
			{
				var role = new IdentityRole { Name = roleName };
				await roleManager.CreateAsync(role);
			}
		}
	}
}
