using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Models;



namespace Turbo.ViewModel
{
    public class ElanYaratViewModel
    {
        public IEnumerable<BanNovu> BanNovleri { get; set; }
        public IEnumerable<Elan> Elanlar { get; set; }
        public IEnumerable<IstehsalIli> IstehsalIllleri { get; set; }
        public IEnumerable<Marka> Markalar { get; set; }
        public IEnumerable<Model> Modeller { get; set; }
        public IEnumerable<MuherrikHecmi> MuherrikHecmleri { get; set; }
        public IEnumerable<Oturucu> Oturuculer { get; set; }
        public IEnumerable<Reng> Rengler { get; set; }
        public IEnumerable<Seher> Seherler { get; set; }
        public IEnumerable<SuretQutusu> SuretQutulari { get; set; }
        public IEnumerable<YanacaqNovu> YanacaqNovleri { get; set; }
        public IEnumerable<Meqale> Meqaleler { get; set; }
        public Meqale Meqale { get; set; }
        public IEnumerable<Rey> Reyler { get; set; }
        public Elan Elan { get; set; }
        public int MarkaCount { get; set; }
        public Edit Edit { get; set; }


    }
}
