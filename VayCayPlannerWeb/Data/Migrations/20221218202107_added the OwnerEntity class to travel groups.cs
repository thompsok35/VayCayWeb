using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VayCayPlannerWeb.Data.Migrations
{
    public partial class addedtheOwnerEntityclasstotravelgroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrimaryTravelGroupId",
                table: "TravelGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TravelerId",
                table: "TravelGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "TravelGroups",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9fecccbcb",
                column: "ConcurrencyStamp",
                value: "86950356-6e2a-4673-8add-ee4fecd132ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70b-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "1b239c8c-0c9e-4bd8-aa66-920525c4cca2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70c-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "23377adf-b45f-4596-87c2-dbd2290927bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70d-4267-b611-aba9feccabcf",
                column: "ConcurrencyStamp",
                value: "1d4d0c71-cddb-4225-ad47-cc970f18a552");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06946e45-c69a-4367-b611-aba9fecccbcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bdffdef-3867-4525-b6eb-9874a066ff39", new DateTime(2022, 12, 18, 15, 21, 6, 744, DateTimeKind.Local).AddTicks(3222), "AQAAAAEAACcQAAAAELXykpNhOGmhXqwe8pmxfTZFMOJS15vRx8AGd8gbguEW0RBdO9ap+svvPAd0fsIT+g==", "3b41b8a4-417d-4bcd-8fff-155c42a24a54" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryTravelGroupId",
                table: "TravelGroups");

            migrationBuilder.DropColumn(
                name: "TravelerId",
                table: "TravelGroups");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TravelGroups");

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
    }
}
