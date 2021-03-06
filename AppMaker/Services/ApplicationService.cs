﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using AppMaker.Models.Options;
using AppMaker.Data.Models;

namespace AppMaker.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppOptions _options;

        public ApplicationService(SignInManager<ApplicationUser> signInManager, IOptionsSnapshot<AppOptions> options)
        {
            _signInManager = signInManager;
            _options = options.Value;
        }
        public string Title
        {
            get
            {
                return _options.Title;
            }
        }

        public string ShortTitle
        {
            get
            {
                return _options.ShortTitle;
            }
        }
    }
}
