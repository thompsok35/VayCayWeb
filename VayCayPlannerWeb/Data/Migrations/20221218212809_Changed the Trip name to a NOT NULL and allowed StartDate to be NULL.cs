using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VayCayPlannerWeb.Data.Migrations
{
    public partial class ChangedtheTripnametoaNOTNULLandallowedStartDatetobeNULL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Trips",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Trips",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9fecccbcb",
                column: "ConcurrencyStamp",
                value: "85ff1f49-d361-4af5-af78-a9df0e8b3574");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70b-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "bc9a4bdb-3fb8-484b-a137-df153edb9fde");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70c-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "8bb4203e-f701-41c9-b942-13c9cfb335e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70d-4267-b611-aba9feccabcf",
                column: "ConcurrencyStamp",
                value: "7dd26492-58ea-482b-bb3f-42755e4d54cb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06946e45-c69a-4367-b611-aba9fecccbcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e53547e-0419-4789-bbb8-ea2f630717a9", new DateTime(2022, 12, 18, 16, 28, 8, 689, DateTimeKind.Local).AddTicks(9101), "AQAAAAEAACcQAAAAEH/kiI9bZvNqDFLdw/Pn0Jr1vewoO6JWtTXGc1tADxqzUi84MulFTDFGidRb1qcyRA==", "aa31490f-2a2d-41b7-932d-bfdd2efe6207" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Trips",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Trips",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70a-4267-b611-aba9fecccbcb",
                column: "ConcurrencyStamp",
                value: "14a30e5a-a87d-4ef0-b1df-3c32dd8ecc79");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70b-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "8ef884b7-af4a-4596-b97c-54bd31accf81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70c-4267-b611-aba9fecacbcb",
                column: "ConcurrencyStamp",
                value: "e91c291f-cff8-4e52-a70c-ae00a30362ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06946e55-f70d-4267-b611-aba9feccabcf",
                column: "ConcurrencyStamp",
                value: "86346fa8-4528-47a5-81ca-5ac8c4edb850");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06946e45-c69a-4367-b611-aba9fecccbcb",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a729e50f-5eb4-4e7f-a205-33019555b237", new DateTime(2022, 12, 18, 16, 2, 55, 423, DateTimeKind.Local).AddTicks(6170), "AQAAAAEAACcQAAAAEKlIjFaZQ72rUtFbPpy/gDck9/6Byr+gMdLAI6IdzxKZTQ0LMN4pxCS4te/Jwiuing==", "70fb5977-7edf-4cf5-bcce-673936cbd68d" });
        }
    }
}
