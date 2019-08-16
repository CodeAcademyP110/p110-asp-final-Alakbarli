using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.ViewModel
{
    public class Edit
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public uint YurusMesafesi { get; set; }
        
        [Required]
        public decimal Qiymet { get; set; }
        
        [Required]
        public uint MuherrikGucu { get; set; }
        [Required]
        public int MuherrikHecmiId { get; set; }
        [Required]
        public string Melumat { get; set; }
        
        [Required]
        public int RengId { get; set; }
        [Required]
        public int OturucuId { get; set; }
        [Required]
        public int YanacaqNovuId { get; set; }
        [Required]
        public int SuretQutusuId { get; set; }
        [Required]
        public int SeherId { get; set; }
        public List<string> DeletedPhotoId { get; set; }
        public string mainImageId { get; set; }
        public string DeleteInput { get; set; }
        public bool Vip { get; set; }
        public List<IFormFile> SekilFayllari { get; set; }

    }
}
