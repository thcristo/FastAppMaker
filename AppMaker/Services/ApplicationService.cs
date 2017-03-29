using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppMaker.Models;
using AppMaker.Models.ApplicationViewModels;

namespace AppMaker.Services
{
    public class ApplicationService : IApplicationService
    {
        public ApplicationViewModel GetApplicationViewModelForUser(ApplicationUser user)
        {
            return new ApplicationViewModel
            {
                Title = "My App Maker",
                ShortTitle = "A"
            };
        }
    }
}
