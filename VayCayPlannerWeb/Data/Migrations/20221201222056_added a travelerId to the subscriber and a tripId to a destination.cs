using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VayCayPlannerWeb.Data.Migrations
{
    public partial class addedatravelerIdtothesubscriberandatripIdtoadestination : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TripId",
                table: "Destinations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TravelerId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_TripId",
                table: "Destinations",
                column: "TripId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Trips_TripId",
                table: "Destinations",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Trips_TripId",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_TripId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "TripId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "TravelerId",
                table: "AspNetUsers");
        }
    }
}
