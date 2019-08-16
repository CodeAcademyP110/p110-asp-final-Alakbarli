using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Turbo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo.DAL
{
    public class DB:IdentityDbContext<User>
    {
        public DB(DbContextOptions<DB>options):base(options)
        {

                
        }
        public DbSet<BanNovu> BanNovleri { get; set; }
        public DbSet<IstehsalIli> IstehsalIlleri { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Meqale> Meqaleler { get; set; }
        public DbSet<Model> Modeller { get; set; }
        public DbSet<MuherrikHecmi> MuherrikHecmleri { get; set; }
        
        public DbSet<Oturucu> Oturuculer  { get; set; }
        public DbSet<Reng> Rengler { get; set; }
        public DbSet<Seher> Seherler { get; set; }
        public DbSet<Sekil> Sekiller { get; set; }
        public DbSet<SuretQutusu> SuretlerQutusu { get; set; }
        public DbSet<YanacaqNovu> YanacaqNovleri { get; set; }
        public DbSet<Elan> Elanlar { get; set; }
        public DbSet<Rey> Reyler { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity(typeof(Marka)).HasData(
                new Marka { Id = 1, Name = "Nissan" },
                new Marka { Id = 2, Name = "Hyundai" },
                new Marka { Id = 3, Name = "Vaz" },
                new Marka { Id = 4, Name = "Dodge" },
                new Marka { Id = 5, Name = "Audi" },
                new Marka { Id = 6, Name = "BMW" },
                new Marka { Id = 7, Name = "Opel" },
                new Marka { Id = 8, Name = "Mercedes" }



                );
            builder.Entity(typeof(Model)).HasData(
                new Model { Id = 1, Name = "GTR R-35", MarkaId = 1 },
                new Model { Id = 2, Name = "GTR R-34", MarkaId = 1 },
                new Model { Id = 3, Name = "Altima", MarkaId = 1 },
                new Model { Id = 4, Name = "Petrol", MarkaId = 1 },
                new Model { Id = 5, Name = "Elantra", MarkaId = 2 },
                new Model { Id = 6, Name = "Azera", MarkaId = 2 },
                new Model { Id = 7, Name = "Coupe", MarkaId = 2 },
                new Model { Id = 8, Name = "Sonata", MarkaId = 2 },
                new Model { Id = 9, Name = "Priora", MarkaId = 3 },
                new Model { Id = 10, Name = "Niva", MarkaId = 3 },
                new Model { Id = 11, Name = "2106", MarkaId = 3 },
                new Model { Id = 12, Name = "2107", MarkaId = 3 },
                new Model { Id = 13, Name = "2108", MarkaId = 3 },
                new Model { Id = 14, Name = "Challenger", MarkaId = 4 },
                new Model { Id = 15, Name = "Charger", MarkaId = 4},
                new Model { Id = 16, Name = "Dart", MarkaId = 4 },
                new Model { Id = 17, Name = "Durango", MarkaId = 4 },
                new Model { Id = 18, Name = "Nitro", MarkaId = 4 },
                new Model { Id = 19, Name = "Stratus", MarkaId = 4 },
                new Model { Id = 20, Name = "A4", MarkaId = 5 },
                new Model { Id = 21, Name = "A4", MarkaId = 5 },
                new Model { Id = 22, Name = "A6", MarkaId = 5 },
                new Model { Id = 23, Name = "Q7", MarkaId = 5 },
                new Model { Id = 24, Name = "Q8", MarkaId = 5 },
                new Model { Id = 25, Name = "TTS", MarkaId = 5 },
                new Model { Id = 26, Name = "525", MarkaId = 6 },
                new Model { Id = 27, Name = "650", MarkaId = 6 },
                new Model { Id = 28, Name = "750", MarkaId = 6 },
                new Model { Id = 29, Name = "M3", MarkaId = 6 },
                new Model { Id = 30, Name = "M4", MarkaId = 6 },
                new Model { Id = 31, Name = "M5", MarkaId = 6 },
                new Model { Id = 32, Name = "X5", MarkaId = 6 },
                new Model { Id = 33, Name = "X6", MarkaId = 6 },
                new Model { Id = 34, Name = "Z4", MarkaId = 6 },
                new Model { Id = 35, Name = "Astra", MarkaId = 7 },
                new Model { Id = 36, Name = "Combo", MarkaId = 7 },
                new Model { Id = 37, Name = "Corsa", MarkaId = 7 },
                new Model { Id = 38, Name = "Omega", MarkaId = 7 },
                new Model { Id = 39, Name = "Vita", MarkaId = 7 },
                new Model { Id = 41, Name = "Zafira", MarkaId = 7 },
                new Model { Id = 42, Name = "190", MarkaId = 8 },
                new Model { Id = 43, Name = "200", MarkaId = 8 },
                new Model { Id = 44, Name = "A200", MarkaId = 8 },
                new Model { Id = 45, Name = "B200", MarkaId = 8 },
                new Model { Id = 46, Name = "C200", MarkaId = 8 },
                new Model { Id = 47, Name = "AMG GT", MarkaId = 8 },
                new Model { Id = 48, Name = "GLK-320", MarkaId = 8 },
                new Model { Id = 49, Name = "ML 500", MarkaId = 8 },
                new Model { Id = 50, Name = "S 500", MarkaId = 8 }


                );
            builder.Entity(typeof(BanNovu)).HasData(
                new BanNovu { Id = 1,Name="Avtobus"},
                new BanNovu { Id = 2, Name = "Furqon" },
                new BanNovu { Id = 3, Name = "Hetcbek" },
                new BanNovu { Id = 4, Name = "Kupe" },
                new BanNovu { Id = 5, Name = "Motosiklet" },
                new BanNovu { Id = 6, Name = "SUV" },
                new BanNovu { Id = 7, Name = "Pikap" },
                new BanNovu { Id = 8, Name = "Sedan" },
                new BanNovu { Id = 9, Name = "Van" }
                );
            
            builder.Entity(typeof(MuherrikHecmi)).HasData(
              new MuherrikHecmi { Id = 1, Hecm=100},
              new MuherrikHecmi { Id = 2, Hecm = 200 },
              new MuherrikHecmi { Id = 3, Hecm = 300 },
              new MuherrikHecmi { Id = 4, Hecm = 400 },
              new MuherrikHecmi { Id = 5, Hecm = 500 },
              new MuherrikHecmi { Id = 6, Hecm = 600 },
              new MuherrikHecmi { Id = 7, Hecm = 700 },
              new MuherrikHecmi { Id = 8, Hecm = 800 },
              new MuherrikHecmi { Id = 9, Hecm = 900 },
              new MuherrikHecmi { Id = 10, Hecm = 1000 },
              new MuherrikHecmi { Id = 11, Hecm = 1200 },
              new MuherrikHecmi { Id = 12, Hecm = 1500 },
              new MuherrikHecmi { Id = 13, Hecm = 2000 },
              new MuherrikHecmi { Id = 14, Hecm = 3000 },
              new MuherrikHecmi { Id = 15, Hecm = 5000 },
              new MuherrikHecmi { Id = 16, Hecm = 6000 },
              new MuherrikHecmi { Id = 17, Hecm = 9000 },
              new MuherrikHecmi { Id = 18, Hecm = 10000 },
              new MuherrikHecmi { Id = 19, Hecm = 15000 }


              );
            builder.Entity(typeof(Oturucu)).HasData(
                new Oturucu { Id=1,Name="Arxa"},
                new Oturucu { Id = 2, Name = "On" },
                new Oturucu { Id = 3, Name = "Tam" }
                );
            builder.Entity(typeof(Reng)).HasData(
                new Reng { Id=1,Name="Ag"},
                new Reng { Id = 2, Name = "Qara" },
                new Reng { Id = 3, Name = "Qehveyi" },
                new Reng { Id = 4, Name = "Yasil" },
                new Reng { Id = 5, Name = "Goy" },
                new Reng { Id = 6, Name = "Qirmizi" },
                new Reng { Id = 7, Name = "Cehrayi" },
                new Reng { Id = 8, Name = "Boz" },
                new Reng { Id = 9, Name = "Qizili" },
                new Reng { Id = 10, Name = "Gumusu" },
                new Reng { Id = 11, Name = "Sari" }
                
                );
            builder.Entity(typeof(Seher)).HasData(
                new Seher { Id = 1, Name = "Baki" },
                new Seher { Id = 2, Name = "Semkir" },
                new Seher { Id = 3, Name = "Gence" },
                new Seher { Id = 4, Name = "Qazax" },
                new Seher { Id = 5, Name = "Qax" },
                new Seher { Id = 6, Name = "Astara" }
                );
            builder.Entity(typeof(SuretQutusu)).HasData(
                new SuretQutusu { Id = 1, Name = "Avtomatik" },
                new SuretQutusu { Id = 2, Name = "Mexaniki" },
                new SuretQutusu { Id = 3, Name = "Yari-Avtomatik" }
                


                );
            builder.Entity(typeof(YanacaqNovu)).HasData(
                new YanacaqNovu { Id = 1, Name = "Benzin" },
                new YanacaqNovu { Id = 2, Name = "Dizel" },
                new YanacaqNovu { Id = 3, Name = "Qaz" },
                new YanacaqNovu { Id = 4, Name = "Hibrid" },
                new YanacaqNovu { Id = 5, Name = "Elektrik" }


                );

        }


    }
}
