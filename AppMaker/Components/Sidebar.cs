using AppMaker.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMaker.Components
{
    public class Sidebar : ViewComponent
    {
        private readonly ApplicationDbContext _dbContext;
        public Sidebar(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menus = await _dbContext.NavigationMenus
                                        .ToListAsync();
            return View(menus);
        }
    }
}
