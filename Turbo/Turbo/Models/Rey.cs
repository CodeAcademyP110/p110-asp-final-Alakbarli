using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class Rey
    {
        public int Id { get; set; }
        [Required]
        [StringLength(5000, MinimumLength = 10, ErrorMessage = "Remark must have min length of 10 and max Length of 50")]
        public string Text { get; set; }
        public int MeqaleId { get; set; }
        public DateTime dateTime { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Meqale Meqale { get; set; }
    }
}
