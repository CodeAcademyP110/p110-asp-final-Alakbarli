using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Turbo.Migrations
{
    public partial class Addednewfea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "IstehsalIlleri");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "YanacaqNovleri",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SuretlerQutusu",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Seherler",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rengler",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Oturuculer",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Modeller",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Melumat",
                table: "Meqaleler",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Basliq",
                table: "Meqaleler",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Meqaleler",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Markalar",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Il",
                table: "IstehsalIlleri",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Melumat",
                table: "Elanlar",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Elanlar",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "YazilmaVaxti",
                table: "Elanlar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BanNovleri",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meqaleler_UserId",
                table: "Meqaleler",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Elanlar_UserId",
                table: "Elanlar",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Elanlar_AspNetUsers_UserId",
                table: "Elanlar",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meqaleler_AspNetUsers_UserId",
                table: "Meqaleler",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elanlar_AspNetUsers_UserId",
                table: "Elanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Meqaleler_AspNetUsers_UserId",
                table: "Meqaleler");

            migrationBuilder.DropIndex(
                name: "IX_Meqaleler_UserId",
                table: "Meqaleler");

            migrationBuilder.DropIndex(
                name: "IX_Elanlar_UserId",
                table: "Elanlar");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Meqaleler");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "IstehsalIlleri");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Elanlar");

            migrationBuilder.DropColumn(
                name: "YazilmaVaxti",
                table: "Elanlar");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "YanacaqNovleri",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SuretlerQutusu",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Seherler",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rengler",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Oturuculer",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Modeller",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Melumat",
                table: "Meqaleler",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 5000);

            migrationBuilder.AlterColumn<string>(
                name: "Basliq",
                table: "Meqaleler",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Markalar",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "IstehsalIlleri",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Melumat",
                table: "Elanlar",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BanNovleri",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
