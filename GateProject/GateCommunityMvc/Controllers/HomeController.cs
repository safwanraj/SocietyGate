using GateCommunityMvc.Data;
using GateCommunityMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace GateCommunityMvc.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _context;
        private readonly IEmailService _emailService;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context,IEmailService emailService)
		{
			_logger = logger;
			_context = context;
			_emailService = emailService;
		}
		public IActionResult Demo()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Demo(Demos model)
		{
			if (ModelState.IsValid)
			{
				var demo = new Demos
				{
					Name = model.Name,
					Contact = model.Contact,
					Email = model.Email,
					role = model.role,
					Societyname = model.Societyname,
					city = model.city
				};
				_context.demos.Add(demo);
				_context.SaveChanges();
                var emailMessage = new EmailMessage
                {
                    To = model.Email,
                    Subject = "Demo Request receive",
                    Body = "Hi " + model.Name + " " +

                        "Greetings from Society Gate , We have received your demo request, we will contact you, thank you" 
                       
                };
                _emailService.SendEmail(emailMessage);
                return RedirectToAction("Index");
			}
			else
			{
				ModelState.AddModelError(string.Empty, "error");
			}
			return View(model);
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Contact()
		{
			return View();
		}
		public IActionResult Blog()
		{
			return View();
		}
		public IActionResult Blog_Details()
		{
			return View();
		}
		public IActionResult BookDemo()
		{
			return View();
		}
		public IActionResult AboutUs()
		{
			return View();
		}

		public IActionResult Solution()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
