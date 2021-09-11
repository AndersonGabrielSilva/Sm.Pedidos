using Domain.ViewModel.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Sm.Pedidos.Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sm.Pedidos.Server.Controllers.Auth
{
    public class AuthController : BaseController
    {
        #region Atributtes
        private readonly ITokenService _tokenService;
        private SignInManager<IdentityUser> _signInManager;
        private UserManager<IdentityUser> _userManager;
        #endregion

        public AuthController(ITokenService tokenService,
                              SignInManager<IdentityUser> signInManager,
                              UserManager<IdentityUser> userManager,
                              IHttpContextAccessor contextAccessor) : base(contextAccessor)
        {
            _tokenService = tokenService;
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

            return Ok(await _tokenService.GenerateTokenAsync(registerUser.Email));
        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginUserViewModel loginUser)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.Values.SelectMany(x => x.Errors));

            var result = await _signInManager.PasswordSignInAsync(loginUser.UserName, loginUser.Password, false, true);

            if (result.Succeeded)
            {
                return Ok(await _tokenService.GenerateTokenAsync(loginUser.Email));
            }

            return BadRequest("Usuário ou senha inválidos");
        }
    }
}
