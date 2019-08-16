using Microsoft.EntityFrameworkCore.Migrations;

namespace Turbo.Migrations
{
    public partial class BesdiDaha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BanNovleri",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Avtobus" },
                    { 2, "Furqon" },
                    { 3, "Hetcbek" },
                    { 4, "Kupe" },
                    { 5, "Motosiklet" },
                    { 6, "SUV" },
                    { 7, "Pikap" },
                    { 8, "Sedan" },
                    { 9, "Van" }
                });

            migrationBuilder.InsertData(
                table: "Markalar",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 8, "Mercedes" },
                    { 7, "Opel" },
                    { 6, "BMW" },
                    { 5, "Audi" },
                    { 4, "Dodge" },
                    { 3, "Vaz" },
                    { 2, "Hyundai" },
                    { 1, "Nissan" }
                });

            migrationBuilder.InsertData(
                table: "MuherrikHecmleri",
                columns: new[] { "Id", "Hecm" },
                values: new object[,]
                {
                    { 19, 15000 },
                    { 18, 10000 },
                    { 17, 9000 },
                    { 16, 6000 },
                    { 14, 3000 },
                    { 13, 2000 },
                    { 12, 1500 },
                    { 11, 1200 },
                    { 10, 1000 },
                    { 15, 5000 },
                    { 8, 800 },
                    { 9, 900 },
                    { 2, 200 },
                    { 3, 300 },
                    { 4, 400 },
                    { 1, 100 },
                    { 5, 500 },
                    { 6, 600 },
                    { 7, 700 }
                });

            migrationBuilder.InsertData(
                table: "Oturuculer",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Arxa" },
                    { 2, "On" },
                    { 3, "Tam" }
                });

            migrationBuilder.InsertData(
                table: "Rengler",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "Gumusu" },
                    { 9, "Qizili" },
                    { 8, "Boz" },
                    { 11, "Sari" },
                    { 6, "Qirmizi" },
                    { 7, "Cehrayi" },
                    { 4, "Yasil" },
                    { 3, "Qehveyi" },
                    { 2, "Qara" },
                    { 1, "Ag" },
                    { 5, "Goy" }
                });

            migrationBuilder.InsertData(
                table: "Seherler",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Astara" },
                    { 4, "Qazax" },
                    { 5, "Qax" },
                    { 2, "Semkir" },
                    { 1, "Baki" },
                    { 3, "Gence" }
                });

            migrationBuilder.InsertData(
                table: "SuretlerQutusu",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Avtomatik" },
                    { 2, "Mexaniki" },
                    { 3, "Yari-Avtomatik" }
                });

            migrationBuilder.InsertData(
                table: "YanacaqNovleri",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Hibrid" },
                    { 1, "Benzin" },
                    { 2, "Dizel" },
                    { 3, "Qaz" },
                    { 5, "Elektrik" }
                });

            migrationBuilder.InsertData(
                table: "Modeller",
                columns: new[] { "Id", "MarkaId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "GTR R-35" },
                    { 27, 6, "650" },
                    { 28, 6, "750" },
                    { 29, 6, "M3" },
                    { 30, 6, "M4" },
                    { 31, 6, "M5" },
                    { 32, 6, "X5" },
                    { 33, 6, "X6" },
                    { 34, 6, "Z4" },
                    { 35, 7, "Astra" },
                    { 36, 7, "Combo" },
                    { 37, 7, "Corsa" },
                    { 38, 7, "Omega" },
                    { 39, 7, "Vita" },
                    { 41, 7, "Zafira" },
                    { 42, 8, "190" },
                    { 43, 8, "200" },
                    { 44, 8, "A200" },
                    { 45, 8, "B200" },
                    { 46, 8, "C200" },
                    { 47, 8, "AMG GT" },
                    { 48, 8, "GLK-320" },
                    { 26, 6, "525" },
                    { 49, 8, "ML 500" },
                    { 25, 5, "TTS" },
                    { 23, 5, "Q7" },
                    { 2, 1, "GTR R-34" },
                    { 3, 1, "Altima" },
                    { 4, 1, "Petrol" },
                    { 5, 2, "Elantra" },
                    { 6, 2, "Azera" },
                    { 7, 2, "Coupe" },
                    { 8, 2, "Sonata" },
                    { 9, 3, "Priora" },
                    { 10, 3, "Niva" },
                    { 11, 3, "2106" },
                    { 12, 3, "2107" },
                    { 13, 3, "2108" },
                    { 14, 4, "Challenger" },
                    { 15, 4, "Charger" },
                    { 16, 4, "Dart" },
                    { 17, 4, "Durango" },
                    { 18, 4, "Nitro" },
                    { 19, 4, "Stratus" },
                    { 20, 5, "A4" },
                    { 21, 5, "A4" },
                    { 22, 5, "A6" },
                    { 24, 5, "Q8" },
                    { 50, 8, "S 500" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BanNovleri",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BanNovleri",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BanNovleri",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BanNovleri",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BanNovleri",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BanNovleri",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BanNovleri",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BanNovleri",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BanNovleri",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Modeller",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MuherrikHecmleri",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Oturuculer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Oturuculer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Oturuculer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rengler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rengler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rengler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rengler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rengler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rengler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rengler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rengler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rengler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rengler",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rengler",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seherler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seherler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seherler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seherler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seherler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seherler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SuretlerQutusu",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SuretlerQutusu",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SuretlerQutusu",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "YanacaqNovleri",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "YanacaqNovleri",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "YanacaqNovleri",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "YanacaqNovleri",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "YanacaqNovleri",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Markalar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Markalar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Markalar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Markalar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Markalar",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Markalar",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Markalar",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Markalar",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
