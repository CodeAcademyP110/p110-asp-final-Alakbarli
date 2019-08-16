using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class MuherrikHecmi
    {
        public MuherrikHecmi()
        {
            Elanlar = new HashSet<Elan>();
        }
        public int Id { get; set; }
        [Required]
        public int Hecm { get; set; }
        public virtual ICollection<Elan> Elanlar { get; set; }
    }
}
