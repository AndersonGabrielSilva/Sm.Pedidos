using Domain.ViewModel.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sm.Pedidos.Server.Controllers.Auth
{
    public class AuthController : BaseController
    {
        #region Atributtes
        private readonly IConfiguration _configuration;
        private SignInManager<IdentityUser> _signInManager;
        private UserManager<IdentityUser> _userManager;
        #endregion

        public AuthController(IConfiguration configuration, 
                              SignInManager<IdentityUser> signInManager,
                              UserManager<IdentityUser> userManager,
                              IHttpContextAccessor contextAccessor) : base(contextAccessor)
        {
            _configuration = configuration;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserViewModel registerUser)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.Values.SelectMany(x => x.Errors));

            var user = new IdentityUser()
            {
                UserName = registerUser.UserName,
                Email = registerUser.Email,
                EmailConfirmed = true,            
            };

            var result = await _userManager.CreateAsync(user, registerUser.Password);

            if (!result.Succeeded) return BadRequest(result.Errors);

            await _signInManager.SignInAsync(user, false);

            return Ok();
        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginUserViewModel LoginUser)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.Values.SelectMany(x => x.Errors));

            
            return Ok();
        }
    }
}
