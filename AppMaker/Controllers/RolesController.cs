using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace AppMaker.Controllers
{
    [Authorize]
    public class RolesController : Controller
    {
        public IActionResult Index()
        {
            return PartialView();
        }
    }
}