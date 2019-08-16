using Microsoft.EntityFrameworkCore.Migrations;

namespace Turbo.Migrations
{
    public partial class AddedUint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "YurusMesafesi",
                table: "Elanlar",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "MuherrikGucu",
                table: "Elanlar",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "YurusMesafesi",
                table: "Elanlar",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "MuherrikGucu",
                table: "Elanlar",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
