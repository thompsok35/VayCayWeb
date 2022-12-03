using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VayCayPlannerWeb.Data.Migrations
{
    public partial class addedidentityusersandroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06946e55-f70a-4267-b611-aba9fecacbcb", "189cd65d-d35d-4af9-abdc-06dbd7c80690", "tripmanager", "TRIPMANAGER" },
                    { "06946e55-f70a-4267-b611-aba9feccabcf", "dcc57869-ba4d-4fee-96f1-24b101c15e49", "user", "USER" },
                    { "06946e55-f70a-4267-b611-aba9fecccbcb", "76cd575c-a768-478c-bb2e-125c48696ec9", "root", "ROOT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Country", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Mobile_Number", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "StreetAddress", "TravelerId", "TwoFactorEnabled", "UserName", "ZipCode", "isActive", "isTraveler" },
                values: new object[] { "06946e55-c69a-4267-b611-aba9fecccbcb", 0, null, "6dea0bad-22c1-42a4-9515-28992fd0837a", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "root@localhost.com", false, "System", "Root", false, null, null, "ROOT@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAENPdSIVVkxZwTsVmvjZKmhqL9Rvrl1m5zeXhkl0rl34RFoSvFA2kLihgdweqFMjXaQ==", null, false, "e894816a-76d0-432a-8e24-085481fc86f3", null, null, null, false, null, null, false, false });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "06946e55-f70a-4267-b611-aba9fecccbcb", "06946e55-c69a-4267-b611-aba9fecccbcb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9fecacbcb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9feccabcf");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "06946e55-f70a-4267-b611-aba9fecccbcb", "06946e55-c69a-4267-b611-aba9fecccbcb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9fecccbcb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06946e55-c69a-4267-b611-aba9fecccbcb");
        }
    }
}
