using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Migrations
{
    public partial class locationFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Cinemas",
                newName: "Name");

            migrationBuilder.AddColumn<double>(
                name: "lat",
                table: "Cinemas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "lng",
                table: "Cinemas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lat",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "lng",
                table: "Cinemas");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cinemas",
                newName: "Location");
        }
    }
}
