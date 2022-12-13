using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VayCayPlannerWeb.Data.Migrations
{
    public partial class Updatedtripmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9fecccbcb",
                column: "ConcurrencyStamp",
                value: "f5723e7d-d3c1-4184-a135-9cea3f3001cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70b-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "c963b46b-9919-4e35-8eb8-7b906fce9a18");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70c-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "c25c2d3a-a825-4ac8-9419-1717ce051bda");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70d-4267-b611-aba9feccabcf",
                column: "ConcurrencyStamp",
                value: "1baa682b-f1f2-45a8-b90e-37765d827fe3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06946e45-c69a-4367-b611-aba9fecccbcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77786d04-a8d6-4094-a5b8-d4ec66562a95", new DateTime(2022, 12, 4, 21, 22, 7, 265, DateTimeKind.Local).AddTicks(6693), "AQAAAAEAACcQAAAAEGNsu6xsYg5g5Kqo3EKO0CuDHFZHm03sHJsvEZei6mmZ5M6VDMJmsMqGz/1YpPUsiQ==", "3442ba00-8510-4275-a009-a803926b97bf" });
        }
    }
}
