using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMaker.Models.Domain
{
    public class ApplicationContext
    {
        public string Title { get; private set; }
        public string ShortTitle { get; private set; }
    }
}
