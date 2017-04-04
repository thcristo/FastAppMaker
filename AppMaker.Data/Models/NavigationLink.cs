using MR.Patterns.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMaker.Data.Models
{
    public class NavigationLink : IEntity<int>
    {
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Caption { get; set; }
        [Required]
        public int RelativeOrder { get; set; }
        public int MenuId { get; set; }
        [Required,ForeignKey("MenuId")]
        public virtual NavigationMenu Menu { get; set; }
        [Required,StringLength(100)]
        public string RelativeUrl { get; set; }
    }
}
