using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using GateCommunityMvc.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Net.Sockets;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.IO;
using GateCommunityMvc.Data;

namespace GateCommunityMvc.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;
		private readonly IEmailService _emailService;


        public AccountController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context,IEmailService emailService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _context = context;
			_emailService = emailService;
        }
        public IActionResult Index()
		{
			
			return View();
		}
        public IActionResult Register()
        {
			var society = _context.Societies.ToList();
			var viewModel = new ResidentView
			{
				SocietyDetails = society.Select(c => new SelectListItem
				{
					Value = c.Society_Id.ToString(),
					Text = c.Society_Name
				}).ToList()
			};
			//List<SocietyDetails> societyDetails = new List<SocietyDetails>().ToList();

			//ViewData["SocietyId"] = new SelectList(_context.Societies.ToList(), "Society_Id", "Society_Name");
			return View(viewModel);
        }
		[HttpPost]
		public async Task<IActionResult> Register(ResidentView model, IFormFile file)
		{
			if (ModelState.IsValid)
			{

				var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

				// Define the file path where the file will be stored
				var filePath = Path.Combine("Uploads/Resident/", fileName);
				// Save the file to the specified file path
				using (var fileStream = new FileStream(filePath, FileMode.Create))
				{
					file.CopyTo(fileStream);
				}
				//var adminid = await _userManager.GetUserAsync(User);
				// Create ApplicationUser
				var user = new ApplicationUser { UserName = model.email, Email = model.email };
				var result = await _userManager.CreateAsync(user, model.password);

				if (result.Succeeded)
				{
					// Assign "President" role to the user
					await _userManager.AddToRoleAsync(user, "Resident");
					int societyid = model.societyid;
					int wingid = model.wingid;
					int flatid = model.flatno;
					// Create Society
					var resident = new Tblresident
					{



						societyid = societyid,
						wingid = wingid,
						flatno = flatid,
						firstname = model.firstname,
						lastname = model.lastname,
						phoneNumber = model.phoneNumber,
						gender = model.gender,
						doc_type = model.doc_type,
						Idfile_name = file.FileName,
						Idfile_Path = filePath,

						status = "Pending",

						CreatedDate = DateTime.UtcNow,
						UpdatedDate = DateTime.UtcNow,
						ApplicationUserId = user.Id
					};

					_context.tblResidents.Add(resident);
					await _context.SaveChangesAsync();

					var society = _context.Societies.FirstOrDefault(s => s.Society_Id == societyid);
					var societyemail = await _userManager.FindByIdAsync(society.ApplicationUserId);

					var emailMessage = new EmailMessage
					{
						To = model.email,
						Subject = "Your Account is Pending Approval",
						Body = "Hi "+model.firstname+" " +
						
						"Welcome to GateSecurity app" +
						"Your account is set up.we are waiting for approval from the adminat "+society.Society_Name+
						"account approval typically takes a few days." +
						"you can reach out to management to expedite approval." +
						"looking forward to having you on board"
					};
					_emailService.SendEmail(emailMessage);
					var adminemail = new EmailMessage {
						To = societyemail.Email,
						Subject = "new resident register",
						Body = "verify new resident:- "+model.firstname+" and approve their registration "


					};
					_emailService.SendEmail(adminemail);
					//	_emailService.SendUserWelcomeEmail(model.email);
					//	_emailService.SendAdminVerificationEmail("rajsaf0hd6@gmail.com");


					return RedirectToAction("Login", "Account");
				}
				else
				{
					foreach (var error in result.Errors)
					{
						ModelState.AddModelError(string.Empty, error.Description);
					}
				}
			}
			//var societylist = _context.Societies.ToList();
			//model.SocietyDetails = societylist.Select(c => new SelectListItem
			//{
			//	Value = c.Society_Id.ToString(),
			//	Text = c.Society_Name
			//}).ToList();

			return View(model);
		}
		
		

		

		//[HttpPost]
		//public IActionResult Loadsociety(string city)
		//{
		//	var subcategories = _context.Societies
		//		.Where(s => s.City == city)
		//		.Select(s => new SelectListItem
		//		{
		//			Value = s.Society_Id.ToString(),
		//			Text = s.Society_Name
		//		}).ToList();


		//	return Json(subcategories);
		//}

		///
		[HttpPost]
        public IActionResult Loadwing(int societyId)
        {
			var subcategories = _context.Wingmodels
				.Where(s => s.Society_Id == societyId)
				.Select(s => new SelectListItem
				{
					Value = s.Id.ToString(),
					Text = s.WingName
				}).ToList();
			

			return Json(subcategories);
        }
		[HttpPost]
		public IActionResult Loadflat(int wingId)
		{
			var subcategories = _context.Flats
				.Where(s => s.WingId == wingId)
				.Select(s => new SelectListItem
				{
					Value = s.Flatid.ToString(),
					Text = s.flatno.ToString()
				}).ToList();

			return Json(subcategories);
		}

		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
		{

			
			if (ModelState.IsValid)
			{
               
                //if (society != null && string.Equals(society.status, "active", StringComparison.OrdinalIgnoreCase))
                //{
                    var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
					if (result.Succeeded)
					{
					var user = await _userManager.FindByEmailAsync(model.Email);
				
					if (await _userManager.IsInRoleAsync(user, "Admin"))
						{
							return RedirectToAction("AdminIndex", "Admin"); // Redirect admin to admin page
						}
						else if (await _userManager.IsInRoleAsync(user, "President"))
						{
                       

                            var society = _context.Societies.FirstOrDefault(s => s.ApplicationUserId == user.Id);
							if (society != null && string.Equals(society.status, "active", StringComparison.OrdinalIgnoreCase))
							{

								return RedirectToAction("SocietyIndex", "Society");// Redirect President to Society page
							}
							else
							{
                            ModelState.AddModelError(string.Empty, "Your account is not active. Please contact the administrator.");
                            return View(model);
							}

						}
						else if (await _userManager.IsInRoleAsync(user, "Guard"))
						{
							return RedirectToAction("GuardIndex", "Guard"); // Redirect Guard to Society page
						}

						else
						{
                        var resident = _context.tblResidents.FirstOrDefault(s => s.ApplicationUserId == user.Id);
                        if (resident != null && string.Equals(resident.status, "Approved", StringComparison.OrdinalIgnoreCase))
                        {

                            return RedirectToAction("ResidentIndex", "Resident");// Redirect President to Society page
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Your account is not active or rejected. Please contact the administrator.");
                            return View(model);
                        }
                       
						}
					}

					if (result.RequiresTwoFactor)
					{
						// Handle two-factor authentication
						// Redirect to a two-factor authentication page
					}
					if (result.IsLockedOut)
					{
						// Handle locked-out account
						// Redirect to a locked-out account page
					}
					else
					{

					var user = await _userManager.FindByNameAsync(model.Email);
					if (user == null)
					{
						ModelState.AddModelError(string.Empty, "Invalid UserName.");
					}
					else if (!await _userManager.CheckPasswordAsync(user, model.Password))
					{
						ModelState.AddModelError(string.Empty, "Invalid Password.");
					}
					//ModelState.AddModelError(string.Empty, "invallid");
					return View(model);
                }
				//}
    //            else
    //            {
    //                ModelState.AddModelError(string.Empty, "Your account is not active. Please contact the administrator.");
    //                return View(model);
    //            }
            }

			return View(model);
		}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }


    }
}
