using AppMaker.Models;
using AppMaker.Models.ApplicationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AppMaker.Services
{
    public interface IApplicationService
    {
        Task<ApplicationViewModel> GetApplicationForUser(ClaimsPrincipal user);
    }
}
