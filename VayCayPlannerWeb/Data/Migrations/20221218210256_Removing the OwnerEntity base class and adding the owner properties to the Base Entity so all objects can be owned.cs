using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VayCayPlannerWeb.Data.Migrations
{
    public partial class RemovingtheOwnerEntitybaseclassandaddingtheownerpropertiestotheBaseEntitysoallobjectscanbeowned : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrimaryTravelGroupId",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TravelerId",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Trips",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryTravelGroupId",
                table: "TravelGroupTrips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TravelerId",
                table: "TravelGroupTrips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "TravelGroupTrips",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TravelGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "TravelGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PrimaryTravelGroupId",
                table: "Travelers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TravelerId",
                table: "Travelers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Travelers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryTravelGroupId",
                table: "TravelerGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryTravelGroupId",
                table: "Packages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TravelerId",
                table: "Packages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryTravelGroupId",
                table: "Lodgings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TravelerId",
                table: "Lodgings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Lodgings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryTravelGroupId",
                table: "Destinations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TravelerId",
                table: "Destinations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryTravelGroupId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "TravelerId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "PrimaryTravelGroupId",
                table: "TravelGroupTrips");

            migrationBuilder.DropColumn(
                name: "TravelerId",
                table: "TravelGroupTrips");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TravelGroupTrips");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TravelGroups");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "TravelGroups");

            migrationBuilder.DropColumn(
                name: "PrimaryTravelGroupId",
                table: "Travelers");

            migrationBuilder.DropColumn(
                name: "TravelerId",
                table: "Travelers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Travelers");

            migrationBuilder.DropColumn(
                name: "PrimaryTravelGroupId",
                table: "TravelerGroups");

            migrationBuilder.DropColumn(
                name: "PrimaryTravelGroupId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "TravelerId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "PrimaryTravelGroupId",
                table: "Lodgings");

            migrationBuilder.DropColumn(
                name: "TravelerId",
                table: "Lodgings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Lodgings");

            migrationBuilder.DropColumn(
                name: "PrimaryTravelGroupId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "TravelerId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Destinations");

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
    }
}
