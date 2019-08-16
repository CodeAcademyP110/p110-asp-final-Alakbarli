using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class Model
    {
        public Model()
        {
            Elanlar = new HashSet<Elan>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        
        public int MarkaId { get; set; }
        public virtual Marka Marka { get; set; }
        public virtual ICollection<Elan> Elanlar { get; set; }
    }
}
