using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Migrations
{
    public partial class seat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TakenSeats_Sessions_SessionId",
                table: "TakenSeats");

            migrationBuilder.DropForeignKey(
                name: "FK_TakenSeats_TicketBookings_TicketId",
                table: "TakenSeats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TakenSeats",
                table: "TakenSeats");

            migrationBuilder.DropIndex(
                name: "IX_TakenSeats_TicketId",
                table: "TakenSeats");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "TakenSeats");

            migrationBuilder.RenameTable(
                name: "TakenSeats",
                newName: "Seats");

            migrationBuilder.RenameIndex(
                name: "IX_TakenSeats_SessionId",
                table: "Seats",
                newName: "IX_Seats_SessionId");

            migrationBuilder.AlterColumn<int>(
                name: "SessionId",
                table: "Seats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketBookingId",
                table: "Seats",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seats",
                table: "Seats",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_TicketBookingId",
                table: "Seats",
                column: "TicketBookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Sessions_SessionId",
                table: "Seats",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_TicketBookings_TicketBookingId",
                table: "Seats",
                column: "TicketBookingId",
                principalTable: "TicketBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Sessions_SessionId",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_Seats_TicketBookings_TicketBookingId",
                table: "Seats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seats",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_TicketBookingId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "TicketBookingId",
                table: "Seats");

            migrationBuilder.RenameTable(
                name: "Seats",
                newName: "TakenSeats");

            migrationBuilder.RenameIndex(
                name: "IX_Seats_SessionId",
                table: "TakenSeats",
                newName: "IX_TakenSeats_SessionId");

            migrationBuilder.AlterColumn<int>(
                name: "SessionId",
                table: "TakenSeats",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "TakenSeats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TakenSeats",
                table: "TakenSeats",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TakenSeats_TicketId",
                table: "TakenSeats",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_TakenSeats_Sessions_SessionId",
                table: "TakenSeats",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TakenSeats_TicketBookings_TicketId",
                table: "TakenSeats",
                column: "TicketId",
                principalTable: "TicketBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
