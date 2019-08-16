using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class YanacaqNovu
    {
        public YanacaqNovu()
        {
            Elanlar = new HashSet<Elan>();
    }
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public  ICollection<Elan> Elanlar { get; set; }
    }
}
