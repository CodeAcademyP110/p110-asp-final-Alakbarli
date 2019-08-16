using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class User:IdentityUser
    {
        public User()
        {
            Elanlar = new HashSet<Elan>();
            Meqaleler = new HashSet<Meqale>();
            Reyler = new HashSet<Rey>();
        }
        [Required, StringLength(50)]
        public string Ad { get; set; }
        [Required, StringLength(50)]
        public string Soyad { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        public virtual ICollection<Elan> Elanlar { get; set; }
        public virtual ICollection<Meqale> Meqaleler { get; set; }
        public virtual ICollection<Rey> Reyler { get; set; }





    }
}
