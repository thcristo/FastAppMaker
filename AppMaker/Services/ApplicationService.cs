using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppMaker.Models;
using AppMaker.Models.ApplicationViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace AppMaker.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<ApplicationViewModel> GetApplicationForUser(ClaimsPrincipal user)
        {
            return new ApplicationViewModel
            {
                Title = "My App Maker",
                ShortTitle = "A"
            };
        }
    }
}
