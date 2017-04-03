namespace AppMaker.Data.Migrations
{
    using AppMaker.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AppMaker.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppMaker.Data.ApplicationDbContext context)
        {
            context.NavigationMenus.AddOrUpdate(menu => menu.Caption,
                new NavigationMenu
                {
                    Caption = "Administration",
                    RelativeOrder = int.MaxValue,
                    Links = new List<NavigationLink>
                    {
                        new NavigationLink { Caption = "Roles", RelativeOrder = 1000},
                        new NavigationLink { Caption = "Users", RelativeOrder = 2000}
                    }
                });
        }
    }
}
