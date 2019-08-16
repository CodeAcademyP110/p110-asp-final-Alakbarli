using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class Sekil
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int ElanId { get; set; }
        public virtual Elan Elan { get; set; }
    }
}
