//
//  DataController.cs
//  needwork
//
//  Created by Baris Tikir on 25.07.20.
//  Copyright © 2020 Baris Tikir. All rights reserved.
// 

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using needwork.backend.Models;

namespace needwork.backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private static UserModel _loggedOutUser = new UserModel { isAuthenticated = true };
        private readonly UserManager<IdentityUser> _userManager;

        public AccountsController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        /// <summary>
        /// records an new Account to the user registration.
        /// </summary>
        /// <param name="model">Created Model from client</param>
        /// <returns>Register result</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegisterModel model)
        {
            //Creating new user with data from body of "/Register"
            var newUser = new IdentityUser { UserName = model.Email, Email = model.Email };
            var result = await _userManager.CreateAsync(newUser, model.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description);

                return Ok(new RegisterResult { Successful = false, Errors = errors });
            }

            return Ok(new RegisterResult { Id = newUser.Id, Successful = true });
        }
    }
}
