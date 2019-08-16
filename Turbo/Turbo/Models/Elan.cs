using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.Models
{
    public class Elan
    {
        public Elan()
        {
            Sekiller = new HashSet<Sekil>();
        }
        public int Id { get; set; }
        [Required]
        public int ModelId { get; set; }
        [Required]
        public uint YurusMesafesi { get; set; }
        public DateTime YazilmaVaxti { get; set; }
        [Required]
        public decimal Qiymet { get; set; }
        public string UserId { get; set; }
        [NotMapped]
        public string MainImageId { get; set; }
        [Required]
        public uint MuherrikGucu { get; set; }
        [Required]
        public int MuherrikHecmiId { get; set; }
        [Required]
        public string Melumat { get; set; }
        [Required]
        public int BanNovuId { get; set; }
        [Required]
        public int RengId { get; set; }
        [Required]
        public int OturucuId { get; set; }
        [Required]
        public int YanacaqNovuId { get; set; }
        [Required]
        public int SuretQutusuId { get; set; }
        [Required]
        public int IstehsalIliId { get; set; }
        
        public string SekilUrl { get; set; }
        [Required]
        public int SeherId { get; set; }
        public bool Vip { get; set; }
        public bool Register { get; set; }
        
        public virtual BanNovu  BanNovu{ get; set; }
        public virtual IstehsalIli IstehsalIli { get; set; }
        public virtual Model Model { get; set; }
        public virtual MuherrikHecmi MuherrikHecmi { get; set; }
        public virtual Oturucu Oturucu { get; set; }
        public virtual Reng Reng { get; set; }
        public virtual Seher Seher { get; set; }
        public virtual YanacaqNovu YanacaqNovu { get; set; }
        public virtual SuretQutusu SuretQutusu{ get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Sekil>   Sekiller{ get; set; }


        [NotMapped]
        public ICollection<IFormFile> SekilFayllari { get; set; }


    }
}
