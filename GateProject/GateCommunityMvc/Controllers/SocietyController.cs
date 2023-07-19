using DocumentFormat.OpenXml.InkML;
using GateCommunityMvc.Data;
using GateCommunityMvc.Migrations;
using GateCommunityMvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace GateCommunityMvc.Controllers
{

    [Authorize(Roles = "President")]
    public class SocietyController : Controller

    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
        private readonly IEmailService _emailService;

        public SocietyController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager,IEmailService emailService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
            _emailService = emailService;

        }
        // GET: SocietyController
        public ActionResult SocietyIndex()
        {
            return View();
        }
        public async Task<IActionResult> Winglist()
        {
            var user = await _userManager.GetUserAsync(User);
            var society = _context.Societies.FirstOrDefault(c => c.ApplicationUserId == user.Id);
            var wing = _context.Wingmodels.Where(c => c.Society_Id == society.Society_Id).ToList();
            return View(wing);
        }

        public async Task<IActionResult> Flatlist()
        {
            var user =await _userManager.GetUserAsync(User);
            var society = _context.Societies.FirstOrDefault(c => c.ApplicationUserId == user.Id);
            var flat=_context.Flats.Include(c=>c.Wingmodel).Where(c=>c.SocietyId==society.Society_Id).ToList();
            return View(flat);
        }
        [HttpGet]
        public async Task<IActionResult> AddWings(int? wingid)
        {
            ViewBag.PageName = wingid == null ? "Create Wings" : "Edit Wings";
            ViewBag.IsEdit = wingid == null ? false : true;
            if (wingid == null)
            {
                return View();
            }

            else
            {
                var wing = await _context.Wingmodels.FindAsync(wingid);

                if (wing == null)
                {
                    return NotFound();
                }
                return View(wing);
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddWings( Wingmodel wing)
        {
           


            if (ModelState.IsValid)
                {
                    // Get the current user
                    var currentUser = await _userManager.GetUserAsync(User);

                    // Retrieve the society associated with the current user
                    var society = _context.Societies.FirstOrDefault(s => s.ApplicationUserId == currentUser.Id);

                    if (society != null)
                    {


                    if (wing.Id == null)
                    {
                        var wings = new Wingmodel
                        {
                            
                            WingName = wing.WingName,
                            nooffloors = wing.nooffloors,
                            Society_Id = society.Society_Id,
                            ApplicationUserId = currentUser.Id,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow

                        };
                        _context.Wingmodels.Add(wings);
                       
                    }
                    else
                    {
                        Wingmodel wingmodel = await _context.Wingmodels.FindAsync(wing.Id);
                        wingmodel.WingName = wing.WingName;
                        wingmodel.nooffloors = wing.nooffloors;
                        wingmodel.UpdatedDate = DateTime.Now;
                        wingmodel.ApplicationUserId = currentUser.Id;
                        _context.Wingmodels.Update(wingmodel);

                    }
                    
                        await _context.SaveChangesAsync();

                        return RedirectToAction("Winglist", "Society");
                    }
                    else
                    {
                        // Society not found for the current user
                        ModelState.AddModelError(string.Empty, "Unable to find the associated society for the current user.");
                    }
                }
            
          

            return View(wing);
        }
        [HttpPost]
        public async Task<IActionResult> Deletewing(int id)
        {
            var wing = await _context.Wingmodels.FindAsync(id);
            if (wing == null)
            {
                return NotFound();

            }
            _context.Wingmodels.Remove(wing);
            await _context.SaveChangesAsync();
            return RedirectToAction("Winglist");
        }



        [HttpGet]
        public async Task<IActionResult> AddFlat(int? id)
        {
            ViewBag.PageName = id == null ? "Create Flat details" : "Edit Flat details";
            ViewBag.IsEdit = id == null ? false : true;
            var currentUser = await _userManager.GetUserAsync(User);

            // Retrieve the society associated with the current user
            var society = _context.Societies.FirstOrDefault(s => s.ApplicationUserId == currentUser.Id);
            if (id == null)
            {

               
                var wings = _context.Wingmodels
                     .Where(s => s.Society_Id == society.Society_Id).ToList();
                var viewModel = new Flatview
                {
                    wingmodels = wings.Select(c => new SelectListItem
                    {
                        Value = c.Id.ToString(),
                        Text = c.WingName
                    }).ToList()
                };
                return View(viewModel);
            }
            else
            {
                var wings = _context.Wingmodels
                    .Where(s => s.Society_Id == society.Society_Id).ToList();
                Flatview fl = new Flatview();
                var flat = await _context.Flats.FindAsync(id);

                if (flat == null)
                {
                    return NotFound();
                }
                fl.flatid = flat.Flatid;
                fl.flatno = flat.flatno;
                fl.floorno = flat.floorno;
                fl.wingid = flat.WingId;
                fl.wingmodels = wings.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.WingName

                }).ToList();
               
                return View(fl);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddFlat(Flatview model)
        {
            if (ModelState.IsValid)
            {
                // Get the current user
                var currentUser = await _userManager.GetUserAsync(User);

                // Retrieve the society associated with the current user
                var society = _context.Societies.FirstOrDefault(s => s.ApplicationUserId == currentUser.Id);
                // var wg= _context.Wingmodels.FirstOrDefault(w => w.Society_Id == society.Society_Id);
                int? selectedwingid = model.wingid;

                if (society != null)
                {
                    if (model.flatid == null)
                    {

                        var flat = new Flatmodel
                        {

                            floorno = model.floorno,
                            flatno = model.flatno,
                            CreatedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now,
                            SocietyId = society.Society_Id,
                            WingId = selectedwingid,

                            CurrentuserId = currentUser.Id



                        };
                        _context.Flats.Add(flat);
                    }
                    else
                    {
                        Flatmodel flatmodel = await _context.Flats.FindAsync(model.flatid);
                        flatmodel.flatno = model.flatno;
                        flatmodel.floorno= model.floorno;
                        flatmodel.UpdatedDate= DateTime.Now;
                        flatmodel.WingId = model.wingid;
                        flatmodel.CurrentuserId= currentUser.Id;
                     
                        _context.Flats.Update(flatmodel);
                    }
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Flatlist", "Society");
                }
                else
                {
                    // Society not found for the current user
                    ModelState.AddModelError(string.Empty, "Unable to find the associated society for the current user.");
                }
            }

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Deleteflat(int id)
        {
            var flat = await _context.Flats.FindAsync(id);
            if (flat == null)
            {
                return NotFound();

            }
            _context.Flats.Remove(flat);
            await _context.SaveChangesAsync();
            return RedirectToAction("Flatlist");
        }
        [HttpGet]
        public async Task<IActionResult> Residentlist()
        {

            var user = await _userManager.GetUserAsync(User);
            var society = _context.Societies.FirstOrDefault(s => s.ApplicationUserId == user.Id);
            var resident = _context.tblResidents.Include(c=>c.SocietyDetails).Include(c=>c.Wingmodel).Include(c=>c.Flatmodel).Where(c => c.societyid == society.Society_Id).ToList();
            return View(resident);
;
        }
        [HttpGet]
        public async Task<IActionResult> Vehiclelist()
        {

            var user = await _userManager.GetUserAsync(User);
            var society = _context.Societies.FirstOrDefault(s => s.ApplicationUserId == user.Id);
            var vehicles = _context.vehicles.Include(c => c.Tblresident).Include(c => c.Wingmodel).Include(c => c.Flatmodel).Where(c => c.societyid == society.Society_Id).ToList();
            return View(vehicles);
            ;
        }
        [HttpGet]
        public IActionResult Addanc()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Addanc(Announcement model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                var society = _context.Societies.FirstOrDefault(c => c.ApplicationUserId == user.Id);
                var anc = new Announcement
                {
                    Title=model.Title,
                    Content=model.Content,
                    PostedDate=DateTime.Now,
                    societyid=society.Society_Id
                };
                _context.announcements.Add(anc);
                await _context.SaveChangesAsync();
                return RedirectToAction("Anclist","Society");
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Anclist()
        {
            var user = await _userManager.GetUserAsync(User);
            var society = _context.Societies.FirstOrDefault(c => c.ApplicationUserId == user.Id);
            var anc = _context.announcements.Where(c => c.societyid == society.Society_Id).ToList();
            return View(anc);
        }
        [HttpGet]
        public IActionResult CreatePoll()
        {
            var model = new PollViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePoll(PollViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                var society = _context.Societies.FirstOrDefault(c => c.ApplicationUserId == user.Id);
                Poll poll = new Poll
                {
                    Question = model.Question,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    societyId = society.Society_Id,
                    Answered=false,
                    Options = new List<Option>()
                };
                var options = new List<Option>();

                // Iterate through the model's Options list and create Option objects
                foreach (var optionText in model.Options)
                {
                    var option = new Option
                    {
                        OptionText = optionText.OptionText,
                        societyId=society.Society_Id,
                        Poll = poll
                    };
                    options.Add(option);
                }

                // Set the Poll's Options property to the list of created options
                poll.Options = options;
                // Create and add the options for the poll
                //foreach (var optionText in model.Options)
                //{
                //    Option option = new Option
                //    {
                //        OptionText = optionText.OptionText,
                //        societyId=society.Society_Id


                //    };
                //    poll.Options.Add(option);
                //}

                // Add the poll and options to the context and save changes
                _context.Polls.Add(poll);
                await _context.SaveChangesAsync();

                return RedirectToAction("SocietyIndex");
            }

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> PollList()
        {
            var user= await _userManager.GetUserAsync(User);
            var society = _context.Societies.FirstOrDefault(c => c.ApplicationUserId == user.Id);
            var polls = _context.Polls.Include(p => p.Options).Where(c=>c.societyId==society.Society_Id).ToList();
            var pollViewModels = polls.Select(p => new PollViewModel
            {
                Id = p.Id,
                Question = p.Question,
                Options = p.Options.ToList()
            }).ToList();

            return View(pollViewModels);
        }





        [HttpPost]
        public async Task<IActionResult> Deleteanc(int id)
        {
            var anc = await _context.announcements.FindAsync(id);
            if (anc == null)
            {
                return NotFound();

            }
            _context.announcements.Remove(anc);
            await _context.SaveChangesAsync();
            return RedirectToAction("Anclist","Society");
        }

        [HttpGet]
        public IActionResult AddSecurity_Guard()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSecurity_Guard(GuardRegister model,IFormFile file)
        {

            if (ModelState.IsValid)
            {
                // Generate a unique file name or use the original file name
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

                // Define the file path where the file will be stored
                var filePath = Path.Combine("Uploads/Guard/", fileName);
                // Save the file to the specified file path
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                var Currentuserid = await _userManager.GetUserAsync(User);
                var society = _context.Societies.FirstOrDefault(s => s.ApplicationUserId == Currentuserid.Id);
                // Create ApplicationUser
                var user = new ApplicationUser { UserName = model.Guard_Email, Email = model.Guard_Email };
                var result = await _userManager.CreateAsync(user, model.Guard_Password);


              
                if (result.Succeeded)

                {
                   
                        // Assign "President" role to the user
                        await _userManager.AddToRoleAsync(user, "Guard");
                    // Save the file path to the database
                    var security_guard = new Security_Guard { 
                        Guard_FullName=model.Guard_FullName,
                        Guard_Contact=model.Guard_Contact,
                        alternate_contact=model.alternate_contact,
                        Guard_Gender = model.Guard_Gender,
                        status = "active",
                        Job_position = model.Job_position,
                        doc_type= model.doc_type,
                        Idfile_name=file.FileName,
                        Idfile_Path=filePath,
                        Societyid=society.Society_Id,
                        ApplicationUserId=user.Id,
                        currentuserid=Currentuserid.Id,
                        createddate=DateTime.UtcNow,
                        updateddate=DateTime.UtcNow





                    };

                  var  final= _context.Security_Guards.Add(security_guard);
                    try
                    {
                        if (final != null)
                        {
                            await _context.SaveChangesAsync();
                            return RedirectToAction("SocietyIndex", "Society");

                        }
                        
                    }
                    catch(Exception ex)
                    {
                        return View(ex);
                    }

                   
                   
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

        public async Task<IActionResult> PendingRegistration()
        {
			var Currentuserid = await _userManager.GetUserAsync(User);
			var society = _context.Societies.FirstOrDefault(s => s.ApplicationUserId == Currentuserid.Id);
			//var pending = _context.tblResidents.Where(r => r.status == "Pending" && r.societyid==society.Society_Id).ToList();
			var children = _context.tblResidents
			.Include(c => c.Wingmodel).Include(c=>c.Flatmodel).Include(c=>c.ApplicationUser)
			.Where(c => c.status=="Pending" && c.societyid == society.Society_Id)
			.ToList();
			return View(children);
        }
        [HttpPost]
        public async Task<IActionResult> HandleRequest(int id, string action)
        {
            var request = _context.tblResidents.FirstOrDefault(r => r.residentId == id);
            var residentemail = await _userManager.FindByIdAsync(request.ApplicationUserId);
            if (request == null)
            {
                return NotFound();
            }
            // Process the approval or rejection based on the action parameter
            if (action == "Approve")
            {
                request.status = "Approved";
                var emailMessage = new EmailMessage
                {
                    To = residentemail.Email,
                    Subject = "Your Account verified and Approved",
                    Body = "Now you can access mygate security services easily"
                };
                _emailService.SendEmail(emailMessage);
                // Handle approval logic
            }
            else if (action == "Reject")
            {
                request.status = "Rejected";
                var emailMessage = new EmailMessage
                {
                    To = residentemail.Email,
                    Subject = "Your Account is rejected",
                    Body = "sorry to say but your account is rejected by admin if yu have any query or doubt please contact your society"
                };
                _emailService.SendEmail(emailMessage);
                // Handle rejection logic
            }
            _context.SaveChanges();

            // Redirect back to the grid view
            return RedirectToAction("SocietyIndex","Society");
        }

        public IActionResult OpenFile(int id)
        {
            var request = _context.tblResidents.FirstOrDefault(r => r.residentId == id);

            if (request == null)
            {
                return NotFound();
            }

            // Assuming the file path is stored in the request object
            string filePath = request.Idfile_Path;

            // Check if the file exists
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            // Determine the content type based on the file extension
            string contentType = GetContentType(filePath);

            // Return the file
            return File(System.IO.File.OpenRead(filePath), contentType);
        }

        // Helper method to determine the content type based on file extension
        private string GetContentType(string filePath)
        {
            // You can use the built-in ContentTypeProvider or create your own logic to determine the content type based on the file extension
            var provider = new FileExtensionContentTypeProvider();
            string contentType;
            if (!provider.TryGetContentType(filePath, out contentType))
            {
                contentType = "application/octet-stream"; // Default content type if not found
            }

            return contentType;
        }

    }
}
