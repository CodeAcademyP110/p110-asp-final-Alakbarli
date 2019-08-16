using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class IstehsalIli
    {
        public IstehsalIli()
        {
            Elanlar = new HashSet<Elan>();
        }
        public int Id { get; set; }
        [Required]
        public int Il { get; set; }
        public ICollection<Elan> Elanlar { get; set; }
    }
}
