using AppMaker.Data.Models;
using MR.AspNet.Identity.EntityFramework6;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMaker.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim, IdentityRoleClaim>
    {
        public ApplicationDbContext(string connectionString) : base(connectionString)
		{
        }
    }
}
