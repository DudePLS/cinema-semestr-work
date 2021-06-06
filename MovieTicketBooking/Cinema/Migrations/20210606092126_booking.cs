using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Migrations
{
    public partial class booking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_TicketBookings_TicketBookingId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_TicketBookingId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "TicketBookingId",
                table: "Seats");

            migrationBuilder.CreateTable(
                name: "BookedSeats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Row = table.Column<int>(type: "int", nullable: false),
                    seat = table.Column<int>(type: "int", nullable: false),
                    TicketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedSeats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookedSeats_TicketBookings_TicketId",
                        column: x => x.TicketId,
                        principalTable: "TicketBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookedSeats_TicketId",
                table: "BookedSeats",
                column: "TicketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookedSeats");

            migrationBuilder.AddColumn<int>(
                name: "TicketBookingId",
                table: "Seats",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seats_TicketBookingId",
                table: "Seats",
                column: "TicketBookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_TicketBookings_TicketBookingId",
                table: "Seats",
                column: "TicketBookingId",
                principalTable: "TicketBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
