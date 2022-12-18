using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VayCayPlannerWeb.Data.Migrations
{
    public partial class MdifiedthetravelerGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelerGroups_Travelers_TravelerId",
                table: "TravelerGroups");

            migrationBuilder.DropIndex(
                name: "IX_TravelerGroups_TravelerId",
                table: "TravelerGroups");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9fecccbcb",
                column: "ConcurrencyStamp",
                value: "cf64c5c5-e5bb-4afa-b123-f07e28a0fb9f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70b-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "40026aa3-d8ce-4d6f-baa6-7b5f4cea8d8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70c-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "87b80b5f-821b-4850-83e1-9477a231ab4a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70d-4267-b611-aba9feccabcf",
                column: "ConcurrencyStamp",
                value: "45fd5712-a3ea-4af4-a767-31582bbd6948");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06946e45-c69a-4367-b611-aba9fecccbcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87eef83f-a980-4376-b04a-d06051c8eed2", new DateTime(2022, 12, 16, 17, 14, 21, 992, DateTimeKind.Local).AddTicks(478), "AQAAAAEAACcQAAAAECbD1+ynq1U1TRx2smPDN0Ylt2bU1MNj6/Lz8YSkvtHhdi2ef7DxFfhJhOK8xggewA==", "a8c9190b-b1d8-4212-97ca-050748036e43" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddForeignKey(
                name: "FK_TravelerGroups_Travelers_TravelerId",
                table: "TravelerGroups",
                column: "TravelerId",
                principalTable: "Travelers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
