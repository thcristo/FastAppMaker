using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMaker.Data
{
    public class ApplicationDbContextFactory : IDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext Create()
        {
            return new ApplicationDbContext("Server = (localdb)\\mssqllocaldb; Database=AppMaker; Trusted_Connection = True; MultipleActiveResultSets = true");
        }
    }
}
