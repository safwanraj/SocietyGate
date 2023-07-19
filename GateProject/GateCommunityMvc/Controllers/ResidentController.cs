using GateCommunityMvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.StaticFiles;

namespace GateCommunityMvc.Controllers
{
    public class ResidentController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public ResidentController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;

        }
        // GET: ResidentController
        public ActionResult ResidentIndex()
        {
            
            return View();
        }

        public async Task<IActionResult> Pendingvisitors()
        {
            var Currentuserid = await _userManager.GetUserAsync(User);
            var resident = _context.tblResidents.FirstOrDefault(s => s.ApplicationUserId == Currentuserid.Id);
            var visitor = _context.visitors.Where(c => c.residentid == resident.residentId && c.status == "Pending").ToList();
            //var pending = _context.tblResidents.Where(r => r.status == "Pending" && r.societyid==society.Society_Id).ToList();
            //var children = _context.tblResidents
            //.Include(c => c.Wingmodel).Include(c => c.Flatmodel).Include(c => c.ApplicationUser)
            //.Where(c => c.status == "Pending" && c.societyid == society.Society_Id)
            //.ToList();
            
            return View(visitor);
        }
        public async Task<IActionResult> HandleRequest(int id, string action)
        {
            var user = await _userManager.GetUserAsync(User);
            var request = _context.visitors.FirstOrDefault(r => r.visitorId == id);

            if (request == null)
            {
                return NotFound();
            }
            // Process the approval or rejection based on the action parameter
            if (action == "Approve")
            {
                request.status = "Approved";
                var entry = new Entryexit
                {
                    visitorid = id,
                    Entry = DateTime.Now,
                    residentid = request.residentid,
                    Applicationuserid = user.Id,
                    societyid=request.societyid,
                    vname=request.visitorName,
                    type="Visitor"


                };
                _context.Add(entry);
                // Handle approval logic
            }
            else if (action == "Reject")
            {
                request.status = "Rejected";

                // Handle rejection logic
            }
            _context.SaveChanges();

            // Redirect back to the grid view
            return RedirectToAction("ResidentIndex", "Resident");
        }
        public IActionResult OpenFile(int id)
        {
            var request = _context.visitors.FirstOrDefault(r => r.visitorId == id);

            if (request == null)
            {
                return NotFound();
            }

            // Assuming the file path is stored in the request object
            string filePath = request.doc_path;

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
        public async Task<IActionResult> Familylist()
        {
            var user = await _userManager.GetUserAsync(User);

            var resident = _context.tblResidents.FirstOrDefault(s => s.ApplicationUserId == user.Id);
            var family = _context.familys.Where(s => s.residentid == resident.residentId).ToList();

            return View(family);
        }
        public async Task<IActionResult> Stafflist()
        {
            var user = await _userManager.GetUserAsync(User);

            var resident = _context.tblResidents.FirstOrDefault(s => s.ApplicationUserId == user.Id);
            var staff= _context.staffs.Where(s=>s.residentid==resident.residentId).ToList();
            return View(staff);
        }
        public async Task<IActionResult> Vehiclelist()
        {
            var user = await _userManager.GetUserAsync(User);

            var resident = _context.tblResidents.FirstOrDefault(s => s.ApplicationUserId == user.Id);
            var vehicle = _context.vehicles.Where(s => s.residentid == resident.residentId).ToList();

            return View(vehicle);
        }
        public IActionResult Addfamily()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Addfamily(Family model, IFormFile file)
        {

            if (ModelState.IsValid)
            {
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

                // Define the file path where the file will be stored
                var filePath = Path.Combine("Uploads/Family/", fileName);
                // Save the file to the specified file path
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                var user = await _userManager.GetUserAsync(User);

                var resident = _context.tblResidents.FirstOrDefault(s => s.ApplicationUserId == user.Id);


                if (resident != null)
                {
                    var family = new Family
                    {

                        FamilyName=model.FamilyName,
                        relationship=model.relationship,
                        email = model.email,
                        contact = model.contact,
                       
                        gender = model.gender,
                       
                       
                        residentid = resident.residentId,
                        
                        filename = file.FileName,
                        filepath = filePath,
                        passcode = GenerateRandomPasscode()


                    };

                    _context.familys.Add(family);

                    await _context.SaveChangesAsync();
                    return RedirectToAction("ResidentIndex");
                }
                else
                {

                    ModelState.AddModelError(string.Empty, "unable to insert family details");

                }
            }
            return View(model);
        }
        public IActionResult Addstaff()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Addstaff(Staffview model,IFormFile file)
        {
            
            if (ModelState.IsValid)
            {
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

                // Define the file path where the file will be stored
                var filePath = Path.Combine("Uploads/Staff", fileName);
                // Save the file to the specified file path
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                var user = await _userManager.GetUserAsync(User);
              
                var resident = _context.tblResidents.FirstOrDefault(s => s.ApplicationUserId==user.Id);
                

                if( resident != null)
                {
                    var staff = new Staff {
                    
                        staffName=model.staffName,
                        email=model.email,
                        contact=model.contact,
                        aadharno=model.aadharno,
                        gender=model.gender,
                        workas=model.workas,
                        societyid=resident.societyid,
                        wingid=resident.wingid,
                        flatid=resident.flatno,
                        residentid=resident.residentId,
                        userId=user.Id,
                        filename=file.FileName,
                        filepath=filePath,
                        passcode=GenerateRandomPasscode()
                    
                    
                    };
                   
                    _context.staffs.Add(staff);
                   
                    await _context.SaveChangesAsync();
                    return RedirectToAction("ResidentIndex");
                }
                else
                {
                    
                        ModelState.AddModelError(string.Empty, "unable to insert staff details");
                    
                }
            }
            return View(model);
        }
        [HttpPost]
       
        public async Task<IActionResult> Deletestaff(int id)
        {
            var staff = await _context.staffs.FindAsync(id);
            if (staff == null)
            {
                return NotFound();

            }
            _context.staffs.Remove(staff);
            await _context.SaveChangesAsync();
            return RedirectToAction("Stafflist");
        }
        private string GenerateRandomPasscode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var passcode = new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return passcode;
        }

        public IActionResult Addvehicle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Addvehicle(Vehicle model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);

                var resident = _context.tblResidents.FirstOrDefault(s => s.ApplicationUserId == user.Id);

                var vehicle = new Vehicle { 
                
                vehicleno=model.vehicleno,
                manufacturer=model.manufacturer,
                vehicletype=model.vehicletype,
                residentid =resident.residentId,
                societyid = resident.societyid,
                wingid =resident.wingid,
                flatid=resident.flatno
                
                };

                _context.vehicles.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction("ResidentIndex", "Resident");
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> PollDetails()
        {
            var user= await _userManager.GetUserAsync(User);
            var resident=_context.tblResidents.FirstOrDefault(c=>c.ApplicationUserId == user.Id);
            var poll = _context.Polls.Include(p => p.Options).Where(p => p.societyId == resident.societyid && p.residentid!=resident.residentId && !p.Answered).ToList();

           
            return View(poll);
        }
        [HttpPost]
        public async Task<IActionResult> SubmitPoll(int pollId, int selectedOption)
        {
            var user = await _userManager.GetUserAsync(User);
            var resident = _context.tblResidents.FirstOrDefault(c => c.ApplicationUserId == user.Id);
            // Retrieve the poll from the database
            var poll = _context.Polls.Include(p => p.Options).FirstOrDefault(p => p.Id == pollId);
            if (poll == null)
            {
                // Poll not found
                return NotFound();
            }
            poll.Answered = true;
            poll.residentid = resident.residentId;

            // Retrieve the selected option
            var option = poll.Options.FirstOrDefault(o => o.Id == selectedOption);
            if (option == null)
            {
                // Option not found
                return NotFound();
            }

            // Increment the vote count for the selected option
            option.VotesCount++;
            _context.SaveChanges();

            // Redirect to the poll results action
            return RedirectToAction("PollResult", new { pollId });
        }

        public IActionResult PollResult(int pollId)
        {
            // Retrieve the poll from the database
            var poll = _context.Polls.Include(p => p.Options).FirstOrDefault(p => p.Id == pollId);
            if (poll == null)
            {
                // Poll not found
                return NotFound();
            }

            // Calculate the total votes for the poll
            var totalVotes = poll.Options.Sum(o => o.VotesCount);

            // Pass the poll and its results to the view
            ViewBag.TotalVotes = totalVotes;
            return View(poll);
        }


        [HttpGet]
        public async Task<IActionResult> Anclist()
        {
            var user = await _userManager.GetUserAsync(User);
            var resident= _context.tblResidents.FirstOrDefault(c=>c.ApplicationUserId==user.Id);
            var anc = _context.announcements.Where(c => c.societyid == resident.societyid).ToList();
            return View(anc);
        }



      
    }
}
