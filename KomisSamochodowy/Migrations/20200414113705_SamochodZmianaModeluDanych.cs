using Microsoft.EntityFrameworkCore.Migrations;

namespace KomisSamochodowy.Migrations
{
    public partial class SamochodZmianaModeluDanych : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JestWCentrali",
                table: "Samochody",
                newName: "JestWcentrali");

            migrationBuilder.AddColumn<bool>(
                name: "JestWCentrali",
                table: "Samochody",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JestWCentrali",
                table: "Samochody");

            migrationBuilder.RenameColumn(
                name: "JestWcentrali",
                table: "Samochody",
                newName: "JestWCentrali");
        }
    }
}
