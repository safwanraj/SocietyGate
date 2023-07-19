using GateCommunityMvc.Data;
using GateCommunityMvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace GateCommunityMvc.Controllers
{
    public class GuardController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
        private readonly IHubContext<VisitorHub> _hubContext;
        public GuardController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IHubContext<VisitorHub> hubContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
            _hubContext = hubContext;

        }
        public async Task<IActionResult> Entryexitlist()
        {
            var user = await _userManager.GetUserAsync(User);
            var guard = _context.Security_Guards.FirstOrDefault(c=>c.ApplicationUserId==user.Id);
            var list=_context.entryexits.Include(c=>c.Tblresident).Where(c=>c.societyid==guard.Societyid).ToList();
            return View(list);
        }
        public IActionResult Entry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string passcode)
        {
            var viewModel = new Searchview();

            // Search in Table1
            viewModel.Families=_context.familys.Include(c=>c.Tblresident)
                .Where(c=>c.passcode==passcode).ToList();

            viewModel.Staffs=_context.staffs.Include(c=>c.societyDetails).Include(c=>c.Tblresident)
                .Where(s=>s.passcode==passcode).ToList();

            return View(viewModel);
        }
        public async Task<IActionResult> Handlestaff(int id, string action)
        {
            var user = await _userManager.GetUserAsync(User);
          //  var guard = _context.Security_Guards.FirstOrDefault(c => c.ApplicationUserId == user.Id);
           
            // Process the approval or rejection based on the action parameter
            if (action == "Staff")
            {
                var request = _context.staffs.FirstOrDefault(r => r.staffId == id);

                if (request == null)
                {
                    return NotFound();
                }
               
                var entry = new Entryexit
                {
                    
                    Entry = DateTime.Now,
                    residentid = request.residentid,
                    Applicationuserid = user.Id,
                    societyid = request.societyid,
                    vname = request.staffName,
                    type = "Staff"
                   


                };
                _context.Add(entry);
                // Handle approval logic
            }
            else if (action == "Family")
            {
                var request = _context.familys.FirstOrDefault(c=>c.FamilyId==id);
                var society=_context.tblResidents.FirstOrDefault(c=>c.residentId==request.residentid);
                if (request == null)
                {
                    return NotFound();
                }
                var entry = new Entryexit
                {

                    Entry = DateTime.Now,
                    residentid = request.residentid,
                    Applicationuserid = user.Id,
                    societyid = society.societyid,
                    vname = request.FamilyName,
                    type = "Family Member"


                };
                _context.Add(entry);

                // Handle rejection logic
            }

            _context.SaveChanges();

            // Redirect back to the grid view
            return RedirectToAction("GuardIndex", "Guard");
        }
        public IActionResult Exit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchExit(string passcode)
        {
            var viewModel = new Searchview();

            // Search in Table1
            viewModel.Families = _context.familys.Include(c => c.Tblresident)
                .Where(c => c.passcode == passcode).ToList();

            viewModel.Staffs = _context.staffs.Include(c => c.societyDetails).Include(c => c.Tblresident)
                .Where(s => s.passcode == passcode).ToList();

            return View(viewModel);
        }

        public async Task<IActionResult> ResidentExit()
        {
            var user = await _userManager.GetUserAsync(User);
            var guard = _context.Security_Guards.FirstOrDefault(s => s.ApplicationUserId == user.Id);

            var entry = _context.entryexits.Include(c => c.Tblresident)
                .Where(c => c.societyid == guard.Societyid && c.visitorid==null && c.Exit == DateTime.MinValue ).ToList();
            return View(entry);
        }
        [HttpPost]
        public IActionResult HandleExit(int id, string action)
        {
            var request = _context.entryexits.FirstOrDefault(r => r.eid == id);

            if (request == null)
            {
                return NotFound();
            }
            // Process the approval or rejection based on the action parameter
            if (action == "Exit")
            {
                request.Exit = DateTime.Now;

                // Handle approval logic
            }

            _context.SaveChanges();

            // Redirect back to the grid view
            return RedirectToAction("ResidentExit", "Guard");
        }

        public IActionResult GuardIndex()
        {
            return View();
        }
        public async Task<IActionResult> Visitorlist()
        {
            var user=await _userManager.GetUserAsync(User);
            var guard = _context.Security_Guards.FirstOrDefault(s => s.ApplicationUserId == user.Id);
            var visitors = _context.entryexits.Include(c=>c.society).Include(c=>c.Tblresident).Include(c=>c.Visitors)
                .Where(s => s.societyid == guard.Societyid).ToList();

            return View(visitors);
        }
        public async Task<IActionResult> Vehiclelist()
        {
            var user = await _userManager.GetUserAsync(User);
            var guard = _context.Security_Guards.FirstOrDefault(s => s.ApplicationUserId == user.Id);



            var vehicles = _context.vehicles.Include(c => c.Tblresident).Include(c=>c.Wingmodel).Include(c=>c.Flatmodel).Where(c => c.societyid == guard.Societyid).ToList();

            return View(vehicles);
        }
        public IActionResult SendNotification(string userId, string message)
        {
            _hubContext.Clients.User(userId).SendAsync("ReceiveNotification", message);
            return Ok();
        }
        public async Task<IActionResult> Visitorsexit()
        {
            var user = await _userManager.GetUserAsync(User);
            var guard = _context.Security_Guards.FirstOrDefault(s => s.ApplicationUserId == user.Id);

            var entry = _context.entryexits.Include(c => c.society).Include(c => c.Visitors).Include(c => c.Tblresident)
                .Where(c => c.societyid == guard.Societyid && c.Exit == DateTime.MinValue).ToList();
            return View(entry);
        }
        [HttpPost]
        public IActionResult HandleRequest(int id, string action)
        {
            var request = _context.entryexits.FirstOrDefault(r => r.eid == id);
           
            if (request == null)
            {
                return NotFound();
            }
            // Process the approval or rejection based on the action parameter
            if (action == "Update")
            {
                request.Exit = DateTime.Now;
              
                // Handle approval logic
            }
           
            _context.SaveChanges();

            // Redirect back to the grid view
            return RedirectToAction("GuardIndex", "Guard");
        }
        public async Task<IActionResult> Addvisitor()
        {
            //var user = await _userManager.GetUserAsync(User);
            //var guard = _context.Security_Guards.FirstOrDefault(s => s.ApplicationUserId == user.Id);
            //var society = _context.Societies.FirstOrDefault(s => s.Society_Id == guard.Societyid);

            //var resident1 = (from c in _context.tblResidents.Where(s => s.societyid == society.Society_Id && s.status == "Approved")
            //                 select new SelectListItem
            //                 {
            //                     Text = c.firstname + " " + c.lastname + " " +
            //                    "flat no - " + c.flatno,
            //                     Value = c.residentId.ToString()
            //                 }).ToList();
            //  ViewBag.message = resident1;
            //  ViewData["ResidentId"] = new SelectList(resident1, "Value", "Text");
            var user = await _userManager.GetUserAsync(User);
            var guard = _context.Security_Guards.FirstOrDefault(s => s.ApplicationUserId == user.Id);
            var society = _context.Societies.FirstOrDefault(s => s.Society_Id == guard.Societyid);
            var wing = (from c in _context.Wingmodels.Where(s => s.Society_Id == society.Society_Id)
                        select new SelectListItem
                        {
                            Text = c.WingName,
                            Value = c.Id.ToString()
                        }).ToList();
            ViewData["Wing"] = new SelectList(wing, "Value", "Text");

            return View();
        }
        [HttpPost]
        public IActionResult Loadres(int wingId)
        {
            var subcategories = _context.tblResidents
                .Where(s => s.wingid == wingId && s.status=="Approved")
                .Select(s => new SelectListItem
                {
                    Value = s.residentId.ToString(),
                    Text = s.firstname+" "+s.lastname+", "
                    +"flat no- "+s.flatno.ToString()
                }).ToList();
          
                return Json(subcategories);
           
        }
        [HttpPost]
        public IActionResult GetFlats(int wingId)
        {
            var flatList = _context.Flats
                .Where(s => s.WingId == wingId)
                .Select(s => new SelectListItem
                {
                    Value = s.Flatid.ToString(),
                    Text = s.flatno.ToString()
                }).ToList();
            // var flat= _context.Flats.Where(s=>s.WingId == wingId).ToList();
            //var flatid = (from c in _context.Flats.Where(s => s.WingId == wingId)
            //            select new SelectListItem
            //            {
            //                Text = c.flatno.ToString(),
            //                Value = c.Flatid.ToString()
            //            });
          /*  var flats = _context.Flats.Where(s => s.WingId == wingId).ToList();
            var flatList = flats.Select(f => new SelectListItem
            {
                Text = f.flatno.ToString(),
                Value = f.Flatid.ToString()
            }).ToList();*/

            return Json(flatList);
        }
        [HttpPost]
        public async Task<IActionResult> Addvisitor(Visitorview model, List<IFormFile> files)
        {
            var user = await _userManager.GetUserAsync(User);
            var guard = _context.Security_Guards.FirstOrDefault(s => s.ApplicationUserId == user.Id);
            var society = _context.Societies.FirstOrDefault(s => s.Society_Id == guard.Societyid);
            var resident = _context.tblResidents.FirstOrDefault(s => s.residentId == model.residentid);
            if (HttpContext.Request.Form.Files.Count >= 2)
            {
                var profilePath1 = HttpContext.Request.Form.Files["profilepath"];
                var profilePath2 = HttpContext.Request.Form.Files["doc"];
                if (profilePath1 != null)
                {
                    var filename1 = Guid.NewGuid().ToString() + Path.GetExtension(profilePath1.FileName);
                   // var filename1= profilePath1.FileName;
                    var filePath1 = Path.Combine("Uploads/Visitor/", filename1);
                    using (var stream = new FileStream(filePath1, FileMode.Create))
                    {
                        profilePath1.CopyTo(stream);
                    }

                    model.profilepath= filePath1;
                }

                if (profilePath2 != null)
                {
                    var filename2= Guid.NewGuid().ToString() + Path.GetExtension(profilePath2.FileName);
                    var filePath2 = Path.Combine("Uploads/Visitor/", filename2);
                    using (var stream = new FileStream(filePath2, FileMode.Create))
                    {
                        profilePath2.CopyTo(stream);
                    }
                    model.docname = profilePath2.FileName;
                    model.docpath= filePath2;
                }

            }

            if (ModelState.IsValid)
            {
              
                
                var visitor = new Visitors { 
                    societyid=society.Society_Id,
                    wingid=resident.wingid,
                    flatid=resident.flatno,
                    residentid=resident.residentId,
                    visitorName=model.visitorName,
                    visitorType=model.visitorType,
                    visitorcontact=model.visitorcontact,
                    purposeofvisit=model.purposeofvisit,
                    workas=model.workas,
                    from=model.from,
                    aadharno=model.aadharno,
                    vehicleno=model.vehicleno,
                    doc_type=model.doc_type,
                    userid=user.Id,
                    gender=model.gender,
                    status="Pending",
                    profilepath=model.profilepath,
                    doc_name=model.docname,
                    doc_path=model.docpath

                
                
                };
                _context.visitors.Add(visitor);
               await _context.SaveChangesAsync();
                string adminId = resident.ApplicationUserId;
                string message = "new visitor is waiting for approval";
                // Notify the specific admin client about the new visitor
               await _hubContext.Clients.User(adminId).SendAsync("ReceiveNotification",message );
                //  await _hubContext.Clients.User(adminId).SendAsync("ReceiveNotification", visitor.visitorName,message );
                return RedirectToAction("GuardIndex");

            }
          
            var wing = (from c in _context.Wingmodels.Where(s => s.Society_Id == society.Society_Id)
                        select new SelectListItem
                        {
                            Text = c.WingName,
                            Value = c.Id.ToString()
                        }).ToList();
            ViewData["Wing"] = new SelectList(wing, "Value", "Text");
            var subcategories = _context.tblResidents
                .Where(s => s.wingid == model.wingid && s.status == "Approved")
                .Select(s => new SelectListItem
                {
                    Value = s.residentId.ToString(),
                    Text = s.firstname + " " + s.lastname + ", "
                    + "flat no- " + s.flatno.ToString()
                }).ToList();
           


            return View(model);
        }
    }
}
