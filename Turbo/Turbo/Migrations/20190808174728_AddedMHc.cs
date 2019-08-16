using Microsoft.EntityFrameworkCore.Migrations;

namespace Turbo.Migrations
{
    public partial class AddedMHc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elanlar_MuherrikHecmleri_MuherrikHecmiId",
                table: "Elanlar");

            migrationBuilder.AlterColumn<int>(
                name: "MuherrikHecmiId",
                table: "Elanlar",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Elanlar_MuherrikHecmleri_MuherrikHecmiId",
                table: "Elanlar",
                column: "MuherrikHecmiId",
                principalTable: "MuherrikHecmleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elanlar_MuherrikHecmleri_MuherrikHecmiId",
                table: "Elanlar");

            migrationBuilder.AlterColumn<int>(
                name: "MuherrikHecmiId",
                table: "Elanlar",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Elanlar_MuherrikHecmleri_MuherrikHecmiId",
                table: "Elanlar",
                column: "MuherrikHecmiId",
                principalTable: "MuherrikHecmleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
