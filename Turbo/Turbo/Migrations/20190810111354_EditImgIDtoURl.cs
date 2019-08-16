using Microsoft.EntityFrameworkCore.Migrations;

namespace Turbo.Migrations
{
    public partial class EditImgIDtoURl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SekilId",
                table: "Elanlar",
                newName: "SekilUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SekilUrl",
                table: "Elanlar",
                newName: "SekilId");
        }
    }
}
