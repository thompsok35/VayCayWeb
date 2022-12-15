using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VayCayPlannerWeb.Data.Migrations
{
    public partial class addedatravelergrouptravelgrouptripsandtravelerGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TravelGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravelGroupTrips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    TravelGroupId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelGroupTrips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravelerGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    TravelerId = table.Column<int>(type: "int", nullable: false),
                    TravelGroupId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelerGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelerGroups_Travelers_TravelerId",
                        column: x => x.TravelerId,
                        principalTable: "Travelers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelerGroups_TravelGroups_TravelGroupId",
                        column: x => x.TravelGroupId,
                        principalTable: "TravelGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9fecccbcb",
                column: "ConcurrencyStamp",
                value: "ec49a6f4-ee74-4383-98db-5842bb15ed73");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70b-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "3942145b-f607-41d0-91f1-1741b80d4a1a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70c-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "c5837d5e-327b-42c0-8fa7-805ae687719c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70d-4267-b611-aba9feccabcf",
                column: "ConcurrencyStamp",
                value: "7dc48af6-6181-4107-9567-225e943e7f18");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06946e45-c69a-4367-b611-aba9fecccbcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67855b15-c5de-47ff-a70c-0b768034ca16", new DateTime(2022, 12, 15, 15, 7, 7, 911, DateTimeKind.Local).AddTicks(3786), "AQAAAAEAACcQAAAAENLU05S2g7hY04RoW+s13X1N5Ma0Iab71wwynUUDkJQnxosRoeJk9aD9/08PzkyhbQ==", "122c48df-c0c0-4537-897f-709994629f59" });

            migrationBuilder.CreateIndex(
                name: "IX_TravelerGroups_TravelerId",
                table: "TravelerGroups",
                column: "TravelerId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelerGroups_TravelGroupId",
                table: "TravelerGroups",
                column: "TravelGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TravelerGroups");

            migrationBuilder.DropTable(
                name: "TravelGroupTrips");

            migrationBuilder.DropTable(
                name: "TravelGroups");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9fecccbcb",
                column: "ConcurrencyStamp",
                value: "0302bcb3-88eb-45f6-be9e-513ff87b79b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70b-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "dbe32187-a8d9-4583-a148-7ce88a514c7a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70c-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "26a86e83-168b-43fd-97bf-a78fd31f2ff0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70d-4267-b611-aba9feccabcf",
                column: "ConcurrencyStamp",
                value: "6bafe730-9ec5-4d07-a01a-c09174fdb692");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06946e45-c69a-4367-b611-aba9fecccbcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0c7a61f-bae5-4c82-9a77-821795dfd0a3", new DateTime(2022, 12, 7, 11, 52, 2, 453, DateTimeKind.Local).AddTicks(5217), "AQAAAAEAACcQAAAAED6S7Q7TiZkhsB9yyyyrYAqOqB5Re/adUTYyUqPnG5KrxZJNL+dqiZxIrthExQgn6A==", "22f1da98-e3b4-46ef-b43b-d4fa79dcc51d" });
        }
    }
}
