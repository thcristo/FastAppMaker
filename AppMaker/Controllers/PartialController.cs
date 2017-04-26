using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace AppMaker.Controllers
{
    [Authorize]
    public class PartialController : Controller
    {
        public IActionResult AppComponent() => PartialView();
        public IActionResult IndexComponent() => PartialView();
        public IActionResult UsersComponent() => PartialView();
        public IActionResult RolesComponent() => PartialView();
    }
}