using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VayCayPlannerWeb.Data.Migrations
{
    public partial class fixingthedefaultrootuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06946e55-c69a-4267-b611-aba9fecccbcb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "f3025cda-c571-41cb-8932-30154e4cfe9c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9feccabcf",
                column: "ConcurrencyStamp",
                value: "0b4e581d-ea47-436f-8ba0-fe023201d67e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9fecccbcb",
                column: "ConcurrencyStamp",
                value: "eb3fe01a-c043-4f69-8116-c35df7672568");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Country", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Mobile_Number", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "StreetAddress", "TravelerId", "TwoFactorEnabled", "UserName", "ZipCode", "isActive", "isTraveler" },
                values: new object[] { "06946e45-c69a-4367-b611-aba9fecccbcb", 0, null, "8ee416c4-b4d3-410f-88cd-5a04205fbe04", null, new DateTime(2022, 12, 3, 11, 48, 22, 79, DateTimeKind.Local).AddTicks(8424), null, "root@localhost.com", true, "System", "Root", false, null, null, "ROOT@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEOLMgOyk2rpIPBykByzgaUrstaR3SRdJ4QgB/Gt4wAbBZF5tV+vuT1y0pnhANozRsQ==", null, false, "fc6cec6a-0240-4463-9eb9-180bd547307a", null, null, null, false, null, null, false, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06946e45-c69a-4367-b611-aba9fecccbcb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "189cd65d-d35d-4af9-abdc-06dbd7c80690");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9feccabcf",
                column: "ConcurrencyStamp",
                value: "dcc57869-ba4d-4fee-96f1-24b101c15e49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9fecccbcb",
                column: "ConcurrencyStamp",
                value: "76cd575c-a768-478c-bb2e-125c48696ec9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Country", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Mobile_Number", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "StreetAddress", "TravelerId", "TwoFactorEnabled", "UserName", "ZipCode", "isActive", "isTraveler" },
                values: new object[] { "06946e55-c69a-4267-b611-aba9fecccbcb", 0, null, "6dea0bad-22c1-42a4-9515-28992fd0837a", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "root@localhost.com", false, "System", "Root", false, null, null, "ROOT@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAENPdSIVVkxZwTsVmvjZKmhqL9Rvrl1m5zeXhkl0rl34RFoSvFA2kLihgdweqFMjXaQ==", null, false, "e894816a-76d0-432a-8e24-085481fc86f3", null, null, null, false, null, null, false, false });
        }
    }
}
