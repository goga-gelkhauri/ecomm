﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.AdminUser
{
    public class CreateUser
    {
        private UserManager<IdentityUser> _userManager;

        public CreateUser(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public class Request
        {
            public string Username { get; set; }
        }

        public async Task<bool> Do(Request request)
        {
            var managerUser = new IdentityUser()
            {
                UserName = request.Username
            };
            await _userManager.CreateAsync(managerUser,"Password");

            var managerClaim = new Claim("Role", "Manager");

            await _userManager.AddClaimAsync(managerUser,managerClaim);

            return true;
        }

    }
}
