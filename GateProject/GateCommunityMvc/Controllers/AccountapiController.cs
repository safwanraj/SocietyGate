using GateCommunityMvc.Data;
using GateCommunityMvc.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GateCommunityMvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountapiController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
       
        
        public AccountapiController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
           
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {

                var user = await _userManager.FindByEmailAsync(model.Email);
                if (await _userManager.IsInRoleAsync(user, "Guard"))
                {
                    
                    return Ok();
                }
               
                // Generate and return a JWT token
                //  var token = GenerateJwtToken(model.Email);
                // return Ok(new { token });

            }

            // Return unauthorized if authentication fails
            return Unauthorized();
        }

    }
}
