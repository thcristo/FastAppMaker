using MR.Patterns.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMaker.Data.Models
{
    public class NavigationMenu : IEntity<int>
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Caption { get; set; }
        [Required]
        public int RelativeOrder { get; set; }
        public virtual List<NavigationLink> Links { get; set; }
    }
}
