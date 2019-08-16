using Microsoft.EntityFrameworkCore.Migrations;

namespace Turbo.Migrations
{
    public partial class EDitUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SekilUrl",
                table: "Elanlar",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SekilUrl",
                table: "Elanlar",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
