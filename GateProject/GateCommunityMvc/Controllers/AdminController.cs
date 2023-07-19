using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using GateCommunityMvc.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using System;

using Microsoft.AspNetCore.Authorization;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace GateCommunityMvc.Controllers
{

	//[Authorize(Roles ="Admin")]
    public class AdminController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly ApplicationDbContext _context;

		
		public AdminController(ApplicationDbContext context,UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
		{
			_userManager = userManager;
			_roleManager = roleManager;
			_context = context;

		}
        //public AdminController(ApplicationDbContext context) {

        //_context = context;
        //}


       
        public IActionResult AdminIndex()
		{
			return View();
		}
        public IActionResult displaySociety()
        {


			var soc= _context.Societies.ToList();

			return View(soc);
           
        }
        public IActionResult Display()
        {


			return View();

        }

		[HttpPost]
        public IActionResult LoadData()
		{
			try
			{
				var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
				// Skiping number of Rows count  
				var start = Request.Form["start"].FirstOrDefault();
				// Paging Length 10,20  
				var length = Request.Form["length"].FirstOrDefault();
				// Sort Column Name  
				var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
				// Sort Column Direction ( asc ,desc)  
				var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
				// Search Value from (Search box)  
				var searchValue = Request.Form["search[value]"].FirstOrDefault();

				//Paging Size (10,20,50,100)  
				int pageSize = length != null ? Convert.ToInt32(length) : 0;
				int skip = start != null ? Convert.ToInt32(start) : 0;
				int recordsTotal = 0;

				// Getting all Customer data  
				var customerData = (from tempcustomer in _context.Societies
									select tempcustomer);
				//     IQueryable<SocietyDetails> customerData =_context.Societies;


				//Sorting  
				if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
				{
					customerData = customerData.OrderBy(sortColumn + " " + sortColumnDirection);
				}
				//Search  
				if (!string.IsNullOrEmpty(searchValue))
				{
					customerData = customerData.Where(m => m.Society_Name == searchValue);
				}

				//total number of rows count   
				recordsTotal = customerData.Count();
				//Paging   
				var data = customerData.Skip(skip).Take(pageSize).ToList();
				//Returning Json Data  
				return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });

			}
			catch (Exception)
			{
				throw;
			}

		}


		[HttpGet]
		public IActionResult AddSociety()
		{

			//var country = new List<Country> { 
			//new Country{Id=1,Name = "India"},
			//new Country{Id=2,Name="Other"}
			
			//};
   //         ViewBag.Countries = country;
            return View();
		}
     //   [Authorize(Roles = "Admin")]
        [HttpPost]
		public async Task<IActionResult> AddSociety(SocietyRegisterView model)
		{

		/*	//create admin
			//await CreateAdminUser();
		*/
			if (ModelState.IsValid)
			{
				var adminid = await _userManager.GetUserAsync(User);
				// Create ApplicationUser
				var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
				var result = await _userManager.CreateAsync(user, model.Password);

				if (result.Succeeded)
				{
					// Assign "President" role to the user
					await _userManager.AddToRoleAsync(user, "President");

					// Create Society
					var society = new SocietyDetails
					{



						Society_Name = model.Society_Name,
						Description = model.Description,
						President_Name = model.President_Name,
						Gender= model.Gender,
						Contact = model.Contact,
						Address=model.Address,
						Country = model.Country,
						State = model.State,
						City = model.City,
						Postal_Code = model.Postal_Code,
						status = "active",
						AdminID = adminid.Id,
						CreatedDate = DateTime.UtcNow,
						UpdatedDate= DateTime.UtcNow,
						ApplicationUserId=user.Id
					};

					_context.Societies.Add(society);
					await _context.SaveChangesAsync();
					

					return RedirectToAction("AdminIndex", "Admin");
				}
				else
				{
					foreach (var error in result.Errors)
					{
						ModelState.AddModelError(string.Empty, error.Description);
					}
				}
			}

			return View(model);
		}

		public IActionResult GetDemos()
		{
			var demo = _context.demos.ToList();
			return View(demo);
		}


		//public async Task<IActionResult> AddPresident()
		//{
		//	// Registration logic

		//	// Call the CreateAdminUser method
		//	await CreateAdminUser();

		//	// Rest of the registration logic
		//}

		private async Task CreateAdminUser()
		{
			var adminEmail = "rajsaf0hd6@gmail.com";
			var adminPassword = "Admin@123";

			if (await _userManager.FindByEmailAsync(adminEmail) == null)
			{
				// Create the admin user
				var adminUser = new ApplicationUser
				{
					UserName = adminEmail,
					Email = adminEmail
				};

				var result = await _userManager.CreateAsync(adminUser, adminPassword);

				if (result.Succeeded)
				{
					// Assign the admin role
					await _userManager.AddToRoleAsync(adminUser, "Admin");
				}
			}
		}
	}
}
