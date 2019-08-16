using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class Meqale
    {
        public Meqale()
        {
            Reyler = new HashSet<Rey>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength =5)]
        public string Basliq { get; set; }
        [Required][StringLength(5000,MinimumLength =10,ErrorMessage ="Meqalede en az 10 her istifade olunmalidir.")]
        public string Melumat { get; set; }
        public DateTime YazilmaVaxti { get; set; }
        public string UserId { get; set; }
        public string Sekil { get; set; }
        [NotMapped]
        
        public IFormFile file { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Rey> Reyler { get; set; }
    }
}
