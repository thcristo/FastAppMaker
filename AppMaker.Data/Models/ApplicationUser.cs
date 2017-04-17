using MR.AspNet.Identity.EntityFramework6;
using MR.Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMaker.Data.Models
{
    public class ApplicationUser : IdentityUser, IEntity<string>
    {
        
    }
}
